import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; // ✅


export class TeacherService {
   private apiUrl = 'https://localhost:7120/api/Teacher';

    constructor(private http: HttpClient){

   }
   
  getApiUrl(): string {
    return this.apiUrl;
  }

  getTeacherCount() {
    return this.http.get<number>(`${this.apiUrl}/count`);
  }
}
