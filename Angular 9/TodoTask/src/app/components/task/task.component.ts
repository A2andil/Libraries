import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TasksDbService } from 'src/app/services/tasks-db.service';
import { discardPeriodicTasks } from '@angular/core/testing';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {

  public id = 1;
  public description = '';
  constructor(private activeRoute : ActivatedRoute, public db: TasksDbService, 
    private router: Router) {
   
  }

  ngOnInit(): void {
    this.activeRoute.params.subscribe(parms => {
      this.id = parms.id;
      this.description = this.db.tasks[this.id].description;
    })
  }

  save(did, des) {
    for (let i = 0; i < this.db.tasks.length; i++) {
      if (this.db.tasks[i].id == did) {
        this.db.tasks[i].description = des;
      }
    }
    this.router.navigateByUrl('/');
  }

}
