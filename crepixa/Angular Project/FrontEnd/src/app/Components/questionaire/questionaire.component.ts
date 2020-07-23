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

  selection = [];

  constructor() { }

  ngOnInit(): void {
    //console.log(window.location.href)

  }

  change_state(obj, val) {
    console.log(this.selection);
    for (let i = 0; i < this.selection.length; i++) {
      if (this.selection[i] == val) {
        if ('toggle-button' == obj.target.className) {
          obj.target.parentElement.classList.remove('toggle-on');
        }
        else {
          obj.target.classList.remove('toggle-on');
        }
        this.selection.splice(i, 1);
        return;
      }
    }
    if (!this.selection.includes(val)) {
      if ('toggle-button' == obj.target.className) {
        obj.target.parentElement.classList.add('toggle-on');
      }
      else {
        obj.target.classList.add('toggle-on');
      }
      this.selection.push(val);
    } 
  }
}
