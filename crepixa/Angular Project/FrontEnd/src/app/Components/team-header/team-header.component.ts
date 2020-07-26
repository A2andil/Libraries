import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-team-header',
  templateUrl: './team-header.component.html',
  styleUrls: ['./team-header.component.css']
})
export class TeamHeaderComponent implements OnInit {

  icon = 'assets/Images/telegram.png';

  employees = [
    {
      'name' : 'GHADA RAMADAN',
      'job_title' : ['Marketing Head']
    },
    {
      'name' : 'AIMAN MANSOUR',
      'job_title' : ['Co-Founder', 'Graphic Design Head']
    },
    {
      'name' : 'MENNA SHETA',
      'job_title' : ['Garaphic Designer']
    },
    {
      'name' : 'AHMED KANDIL',
      'job_title' : ['Software Engineer']
    }
  ];

  trainee = [
    {
      'name' : 'GHADA RAMADAN',
      'job_title' : ['Marketing Head']
    },
    {
      'name' : 'AIMAN MANSOUR',
      'job_title' : ['Co-Founder', 'Graphic Design Head']
    },
    {
      'name' : 'MENNA SHETA',
      'job_title' : ['Garaphic Designer']
    }
  ];

  constructor() { }

  ngOnInit(): void {
    
  }

}
