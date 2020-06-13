import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Task } from 'src/app/interfaces/task';
import { TasksDbService } from 'src/app/services/tasks-db.service';

@Component({
  selector: 'app-insertion',
  templateUrl: './insertion.component.html',
  styleUrls: ['./insertion.component.css']
})
export class InsertionComponent implements OnInit {

  public task: Task = {
    id : 0,
    description: '',
    title : ''
  };
  constructor(private router: Router, private db : TasksDbService) { 

  }

  ngOnInit(): void {
    for (let i = 0; i < this.db.tasks.length; i++) {
      this.task.id = this.db.tasks[i].id > this.task.id?
           this.db.tasks[i].id : this.task.id;
    }
    this.task.id += 1;
  }

  insert() {
    this.db.tasks.push({
      id: this.task.id,
      description: this.task.description,
      title: this.task.title
    });
    this.router.navigateByUrl('');
  }
}
