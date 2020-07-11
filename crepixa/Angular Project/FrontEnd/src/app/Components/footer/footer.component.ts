import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  socials = ['assets/Images/be.png', 'assets/Images/facebook.png',
  'assets/Images/telegram.png', 'assets/Images/twitter.png',
  'assets/Images/fi.png', 'assets/Images/instagram.png'];

}
