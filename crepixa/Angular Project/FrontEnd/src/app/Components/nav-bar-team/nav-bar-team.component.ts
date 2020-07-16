import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-bar-team',
  templateUrl: './nav-bar-team.component.html',
  styleUrls: ['./nav-bar-team.component.css']
})
export class NavBarTeamComponent implements OnInit {

  constructor() { }

  logo = 'assets/Images/Logo.png';
  
  ngOnInit(): void {

  }

  ngAfterViewInit() {
    $('.menu-toggle').click(function() {
      $('nav').toggleClass('active');
    });
}

}
