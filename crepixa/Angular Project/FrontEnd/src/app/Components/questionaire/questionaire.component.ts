import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-questionaire',
  templateUrl: './questionaire.component.html',
  styleUrls: ['./questionaire.component.css']
})
export class QuestionaireComponent implements OnInit {


  xs = ['Branding', 'Advertising', 'Social Media', 'Marketing', 'Motion Graphics', 'Web Design', 'App Design'];

  branding = ['Logo Design', 'Full Brand', 'App Design'];

  constructor() { }

  ngOnInit(): void {
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
