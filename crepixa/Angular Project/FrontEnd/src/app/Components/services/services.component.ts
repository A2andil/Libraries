import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  services1 = [
      {'name': 'BRANDING', 'image':'assets/Images/branding.png'},
      {'name': 'ADVERTISING', 'image': 'assets/Images/advertising.png'},
      {'name': 'SOCIAL MEDIA', 'image': 'assets/Images/socialmedia.png'}
   ];

    services2 = [
        {'name': 'MARKETING', 'image':'assets/Images/marketing.png'},
        {'name': 'MOTION GRAPHICS', 'image': 'assets/Images/motiongraphics.png'},
        {'name': 'WEB DESIGN', 'image': 'assets/Images/webdesign.png'},
        {'name': 'APP DESIGN', 'image': 'assets/Images/appdesign.png'}
    ];

  constructor() { }

  ngOnInit(): void {
  }

}
