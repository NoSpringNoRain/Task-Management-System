import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserTasks } from 'src/app/core/models/usertask';
import { UserTasksHistory } from 'src/app/core/models/usertaskhistory';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  id: number = 0;
  tasks!: UserTasks;
  tasksHistory!: UserTasksHistory

  constructor(private activatedRouter: ActivatedRoute, private userService: UserService) { }

  ngOnInit(): void {
    this.activatedRouter.paramMap.subscribe
    (
      p => {
        this.id = Number(p.get('id'));
        this.userService.getAllTasksForUser(this.id)
        .subscribe(
          t => {
            this.tasks = t;
            console.table(this.tasks.tasks)
            console.log(this.tasks.totalTasksCount)
          }
        );
        this.userService.getAllTasksHistoryForUser(this.id)
        .subscribe(
          th => {
            this.tasksHistory = th;
            console.log(this.tasksHistory.totalTasksHistoryCount)
          }
        )
      }
    )
  }

}
