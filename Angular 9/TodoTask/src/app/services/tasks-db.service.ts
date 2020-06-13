import { Injectable } from '@angular/core';
import { Task } from '../interfaces/task';

@Injectable({
  providedIn: 'root'
})
export class TasksDbService {
  tasks: Array<Task> = [
    {
      id : 1,
      title : 'task 1',
      description : 'lorem lamspknob'
    },
    {
      id : 2,
      title : 'task 2',
      description : 'lorem lamspknob'
    }
    ,
    {
      id : 3,
      title : 'task 3',
      description : 'lorem lamspknob'
    }
  ];
  constructor() { }

  addTask(t:Task) {

  }

  removeTask(id) {

  }

  editTask(id, t:Task) {

  }
}
