import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-questionaire-header',
  templateUrl: './questionaire-header.component.html',
  styleUrls: ['./questionaire-header.component.css']
})
export class QuestionaireHeaderComponent implements OnInit {

  icon = 'assets/Images/telegram.png';

  constructor() { }

  ngOnInit(): void {
  }

}
