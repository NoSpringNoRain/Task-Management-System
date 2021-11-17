import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from 'src/app/core/models/user';
import { UserTasksHistory } from 'src/app/core/models/usertaskhistory';
import { UserTasks } from 'src/app/core/models/usertask';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(`${environment.appBaseUrl}users`);
  }

  getAllTasksForUser(id: number): Observable<UserTasks> {
    return this.http.get<UserTasks>(`${environment.appBaseUrl}users/${id}/tasks`)
  }

  getAllTasksHistoryForUser(id: number): Observable<UserTasksHistory> {
    return this.http.get<UserTasksHistory>(`${environment.appBaseUrl}users/${id}/taskshistory`)
  }
}
