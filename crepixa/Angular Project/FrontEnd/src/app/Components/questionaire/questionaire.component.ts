import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-questionaire',
  templateUrl: './questionaire.component.html',
  styleUrls: ['./questionaire.component.css']
})
export class QuestionaireComponent implements OnInit {


  xs = ['Branding', 'Advertising', 'Social Media', 'Marketing', 'Motion Graphics', 'Web Design', 'App Design'];

  branding = ['Logo Design', 'Full Brand', 'App Design'];

  Question = ['What is the name of your business ?', 'What is your business sector?',
   'What kind of products and / or services do you provide?',
   'Who is your target market?'];

  lst = [1, 2, 3, 4, 5, 6, 7, 8, 9];

  constructor() { }

  ngOnInit(): void {
    console.log(window.location.href)
    $('.toggle').click(function(e){
      e.preventDefault(); // The flicker is a codepen thing
      $(this).toggleClass('toggle-on');
      if ($(".black")[0]){
        $('#switch').removeClass('black');
      } else {
        $('#switch').addClass('black');
      }
   });

  }

  printlog(v) {
    console.log(v);
  }

}
