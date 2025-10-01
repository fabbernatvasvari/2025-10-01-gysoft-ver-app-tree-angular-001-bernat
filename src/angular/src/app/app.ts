import { Component, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Student } from './student/student';
import { Database } from './database/database';
import { Teacher } from './teacher/teacher';
import { NgModel } from '@angular/forms';
import { CommonModule } from '@angular/common'; 
import { HttpClient } from '@angular/common/http';
import { TeacherService } from './teacher-service';

// tryna integrate HttpClient
import {HttpClientModule} from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.sass',
})
export class App implements OnInit{
  protected readonly title = signal('Vasvári Tanár Értekelő Rendszer');
  
  
  teacherCount: number | null = null;
  student: Student;
  teacher: Teacher;
  teacherNames: string[] = [];
  teacherService: TeacherService | null = null;
  
  
  constructor() {
    this.student = new Student();
    this.teacher = new Teacher();
    this.student.name = Database.getName();
    this.teacherService = new TeacherService(Object as any);
    this.student.teachers = Database.getTeachers().map(currentTeacher => {
      const teacher = new Teacher();
      console.log(teacher);
      teacher.name = currentTeacher.toString();
      return teacher;
    });

    for (const teacher of this.student.teachers){
      this.teacherNames.push(teacher.name);
    }
    this.teacherNames = [...this.teacherNames, ...this.teacher.getAllRandomNames()]
  }
  ngOnInit(): void {
    this.teacherService?.getTeacherCount().subscribe({
      next: (count) => {
        this.teacherCount = count;
        console.log('Teacher count:', count);
      },
      error: (error) => {
        console.error('Error fetching teacher count:', error);
      }
    });
  }


  public teacherServiceAccessor(): TeacherService {
    return this.teacherService??(new TeacherService(Object as any));
  }


  onTeacherChange($event: Event) {
  throw new Error('Method not implemented.');
  }

  
  MakeHttpRequestToEndPoint(arg0: string) {
    return arg0;
  }
}