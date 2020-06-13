import { Component, OnInit } from '@angular/core';
import { TasksDbService } from 'src/app/services/tasks-db.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(public db: TasksDbService) { }

  ngOnInit(): void {
  }

  delete(id) {
    this.db.tasks.splice(id, 1);
  }
}
