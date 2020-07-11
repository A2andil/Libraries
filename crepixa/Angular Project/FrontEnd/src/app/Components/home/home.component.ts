import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  logo:string = "assets/Images/Logo.png";
  picture:string = "assets/Images/Person.png";
  socials = ['assets/Images/be.png', 'assets/Images/facebook.png',
            'assets/Images/telegram.png', 'assets/Images/twitter.png',
            'assets/Images/fi.png', 'assets/Images/instagram.png'];

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
  
  images = [944, 1011, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);

  ans = [];
  constructor() { }

  elements = [1, 2, 3, 4 , 5, 6, 7, 8, 9, 10, 11, 12, 13]

  elementsx = [
    {'id' : 1, 'image' : 'assets/Images/Asset23.png'},
    {'id' : 2, 'image' : 'assets/Images/Asset24.png'},
    {'id' : 3, 'image' : 'assets/Images/Asset25.png'},
    {'id' : 4, 'image' : 'assets/Images/Asset26.png'},
    {'id' : 5, 'image' : 'assets/Images/Asset23.png'},
    {'id' : 6, 'image' : 'assets/Images/Asset24.png'},
    {'id' : 7, 'image' : 'assets/Images/Asset25.png'},
    {'id' : 8, 'image' : 'assets/Images/Asset26.png'}
  ];


 sz = 6;
 z = 0;
 v = 0;


  ngOnInit(): void {
    console.log(this.images);
  }

  done(x) {
    this.ans = [];
    for (let i = 1; i <= this.sz; i++) {
      this.z = (i + x) % this.elements.length;
      this.ans.push(this.z == 0? this.elements.length : this.z);
    }
    return this.ans;
  }

  donex(x) {
    this.ans = [];
    for (let i = 1; i <= this.sz; i++) {
      this.z = (i + x) % this.elementsx.length;
      this.v = this.z == 0? this.elementsx.length : this.z;
      this.ans.push(this.elementsx[this.z]);
    }
    return this.ans;
  }

  upd() {
    window.scroll(0,0);
  }

  moveto(x) {
    console.log(x);
  }

  getAllProjects() {
    return this.elementsx.slice(0, 6);
  }
}
