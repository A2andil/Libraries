import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  images = [944, 1011, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);
  ans = [];
  constructor() { }

  elements = [1, 2, 3, 4 , 5, 6, 7, 8, 9, 10, 11, 12, 13]

 sz = 6;
 z = 0;


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

  upd() {
    window.scroll(0,0);
  }
}
