import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Student } from './student/student';
import { Database } from './database/database';
import { Teacher } from './teacher/teacher';
import { NgModel } from '@angular/forms';
import { CommonModule } from '@angular/common'; 

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.sass'
})
export class App {
  protected readonly title = signal('Vasvári Tanár Értekelő Rendszer');
  student: Student;
  teacher: Teacher;
  teacherNames: string[] = [];

  constructor() {
    this.student = new Student();
    this.teacher = new Teacher();
    this.student.name = Database.getName();
    this.student.teachers = Database.getTeachers().map(name => {
      const teacher = new Teacher();
      teacher.name = name.toString();
      return teacher;
    });

    for (const teacher of this.student.teachers){
      this.teacherNames.push(teacher.name);
    }

    this.teacherNames = [...this.teacherNames, ...this.teacher.getAllRandomNames()]
  }

  onTeacherChange($event: Event) {
  throw new Error('Method not implemented.');
  }
}
