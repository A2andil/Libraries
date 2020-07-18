import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-questionaire',
  templateUrl: './questionaire.component.html',
  styleUrls: ['./questionaire.component.css']
})
export class QuestionaireComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    $('.toggle').click(function(e){
      e.preventDefault(); // The flicker is a codepen thing
      $(this).toggleClass('toggle-on');
      $('#switch').addClass('black');
   });
  }

}
