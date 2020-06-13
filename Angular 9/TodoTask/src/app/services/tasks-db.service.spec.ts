import { TestBed } from '@angular/core/testing';

import { TasksDbService } from './tasks-db.service';

describe('TasksDbService', () => {
  let service: TasksDbService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TasksDbService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
