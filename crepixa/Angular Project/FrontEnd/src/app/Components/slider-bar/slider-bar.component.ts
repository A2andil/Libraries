import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slider-bar',
  templateUrl: './slider-bar.component.html',
  styleUrls: ['./slider-bar.component.css']
})
export class SliderBarComponent implements OnInit {

  img = 'assets/Images/Asset22.png';
  images = [494, 1011, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);

  constructor() { }

  ngOnInit(): void {
  }

  getimages() {
    return this.images.slice(0, 3);
  }

  range() {
    var element = [];
    for (let i = 0; i <= this.images.length; i++) {
      element.push(i);
    }
    return element;
  }
}
