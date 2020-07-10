import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  pth:string = "assets/Images/Logo.png";
  constructor() { }

  ngOnInit(): void {
  }

}
