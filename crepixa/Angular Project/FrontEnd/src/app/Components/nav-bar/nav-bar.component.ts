import { Component, OnInit , AfterViewInit} from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit, AfterViewInit {

  logo = 'assets/Images/Logo.png';
  constructor() { }

  ngOnInit(): void {

  }

  ngAfterViewInit() {
    $('.menu-toggle').click(function() {
      $('nav').toggleClass('active');
    });
}

}
