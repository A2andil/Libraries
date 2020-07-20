import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-project-slider',
  templateUrl: './project-slider.component.html',
  styleUrls: ['./project-slider.component.css']
})
export class ProjectSliderComponent implements OnInit {

  img = 'assets/Images/Asset22.png';
  images = [494, 1011, 984].map((n) => `https://picsum.photos/id/${n}/900/500`);
  
  constructor() { }

  ngOnInit(): void {
  }

}
