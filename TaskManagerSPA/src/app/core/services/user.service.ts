import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from 'src/app/core/models/user';
import { TasksHistory } from 'src/app/core/models/taskhistory';
import { Tasks } from 'src/app/core/models/task';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${environment.appBaseUrl}users`);
  }

  getAllTasksForUser(id: number): Observable<Tasks> {
    return this.http.get<Tasks>(`${environment.appBaseUrl}users/${id}/tasks`)
  }

  getAllTasksHistoryForUser(id: number): Observable<TasksHistory> {
    return this.http.get<TasksHistory>(`${environment.appBaseUrl}users/${id}/taskshistory`)
  }
}
