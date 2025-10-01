import { Component } from '@angular/core';
import { Database } from '../database/database';
import { Teacher } from '../teacher/teacher';

@Component({
  selector: 'app-student',
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.sass'
})
export class Student {
  public name: string = Database.getName();
  public teachers: Teacher[] = new Array<Teacher>;

}