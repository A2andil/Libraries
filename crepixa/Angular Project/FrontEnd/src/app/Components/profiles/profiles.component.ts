import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profiles',
  templateUrl: './profiles.component.html',
  styleUrls: ['./profiles.component.css']
})
export class ProfilesComponent implements OnInit {

  c = 'assets/Images/Asset23.png';
  g
  constructor() { }
  rs = [];
  idx = 0;

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

  ngOnInit(): void {
    for (let j = 0; j < 7; j++)
      this.rs.push(this.elementsx[j].image);
  }

  ans = [];

  elements = [1, 2, 3, 4 , 5, 6, 7, 8, 9, 10, 11, 12, 13]



  reset() {
    this.idx += 1;
    for (let j = 0; j < 6; j++) {
      this.rs[j] = this.rs[j + 1];
    }
    this.rs[6] = this.elementsx[(this.idx + 7) % this.elementsx.length].image;
  }


 sz = 6;
 z = 0;
 v = 0;

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
