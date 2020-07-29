import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  xs = [
    ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M'],
    ['N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'],
    ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm'],
    ['n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
  ]

  digits = [
    [0 ,1, 2, 3, 4, 5, 6, 7, 8, 9 , 10]
  ];

  images = [
    'assets/Temp/header.png',
    'assets/Temp/Ghada.png',
    'assets/Temp/Ghada_top.png',
    'assets/Temp/Ghada_left.png',
    'assets/Temp/Ghada_second_top.png',
    'assets/Temp/Ghada_second_down.png',
    'assets/Temp/Ghada_second_left.png',
    'assets/Temp/Ghada_third.png',
    'assets/Temp/Ghada_fourth.png',
    'assets/Temp/Ghada_fourth_top.png',
    'assets/Temp/Ghada_fourth_down.png'
    
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
