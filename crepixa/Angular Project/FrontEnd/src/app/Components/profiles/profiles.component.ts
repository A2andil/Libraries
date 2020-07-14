import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profiles',
  templateUrl: './profiles.component.html',
  styleUrls: ['./profiles.component.css']
})
export class ProfilesComponent implements OnInit {

  constructor() { }
  rs = []; idx = 0;
  next = 'assets/Users/next.png';
  selected = 'assets/Users/icon1.png';
  current_obj = {
    'name' : 'MAZEN ALSAWAF',
    'title' : 'YOUTEBER AND CONTENT MAKER',
    'image' : 'assets/Images/Person.png',
    'description' : 'Lorem, ipsum dolor sit amet consectetur adipisicing elit. Placeat nemo non aut veritatis dolores voluptatem vel totam. Quia, blanditiis ipsam magni, voluptas vitae suscipit eius numquam vel impedit dignissimos aspernatur. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Natus temporibus iusto quod enim nobis repellendus saepe laudantium nemo dolor vel totam assumenda, quis fugit unde architecto distinctio tempora sit? Illum.',
    'projects' : []
  }
  selected_projects = [];

  icons = [
    {'user' : 'mazen', 'image' : 'assets/Users/icon1.png'},
    {'user' : 'ibrahim', 'image' : 'assets/Users/icon2.png'},
    {'user' : 'ossama', 'image' : 'assets/Users/icon3.png'},
    {'user' : 'ali', 'image' : 'assets/Users/icon4.png'},
    {'user' : 'islam', 'image' : 'assets/Users/icon5.png'},
    {'user' : 'fady', 'image' : 'assets/Users/icon6.png'},
    {'user' : 'ehab', 'image' : 'assets/Users/icon7.png'},
  ];

  black_icons = [
    {'user' : 'mazen', 'image' : 'assets/Users/icon1b.png'},
    {'user' : 'ibrahim', 'image' : 'assets/Users/icon2b.png'},
    {'user' : 'ossama', 'image' : 'assets/Users/icon3b.png'},
    {'user' : 'ali', 'image' : 'assets/Users/icon4b.png'},
    {'user' : 'islam', 'image' : 'assets/Users/icon5b.png'},
    {'user' : 'fady', 'image' : 'assets/Users/icon6b.png'},
    {'user' : 'ehab', 'image' : 'assets/Users/icon7b.png'},
  ];


  projects = [
    {'id' : 1, 'image' : 'assets/Images/Asset23.png', 'user' : 'mazen'},
    {'id' : 2, 'image' : 'assets/Images/Asset24.png', 'user' : 'ossama'},
    {'id' : 3, 'image' : 'assets/Images/Asset25.png', 'user' : 'mazen'},
    {'id' : 4, 'image' : 'assets/Images/Asset26.png', 'user' : 'ossama'},
    {'id' : 5, 'image' : 'assets/Images/Asset23.png', 'user' : 'mazen'},
    {'id' : 6, 'image' : 'assets/Images/Asset24.png', 'user' : 'ossama'},
    {'id' : 7, 'image' : 'assets/Images/Asset25.png', 'user' : 'ali'},
    {'id' : 8, 'image' : 'assets/Images/Asset26.png', 'user' : 'ali'}
  ];

  ngOnInit(): void {
    for (let j = 0; j < 7; j++)
      this.rs.push(this.icons[j].image);
    this.change(this.selected);
    this.current_obj.projects = this.selected_projects;
  }

  ans = [];
  tmp = '';


  reset() {
    this.idx += 1;
    this.tmp = this.rs[0];
    for (let j = 0; j < this.rs.length - 1; j++) {
      this.rs[j] = this.rs[j + 1];
    }
    this.rs[this.rs.length - 1] = this.tmp;
  }

  sz = 6;

  getAllProjects() {
    return this.projects.slice(0, 6);
  }

  get_black(j) {
    var ret = this.rs[j].replace('.', 'b.');
    return ret;
  }

  change(s) {
    this.selected = s;
    for (let i = 0; i < this.icons.length; i++) {
      if (this.icons[i].image == s) {
        this.selected_projects = [];
        for (let j = 0; j < this.projects.length; j++) {
          if (this.projects[j].user == this.icons[i].user)
              this.selected_projects.push(this.projects[j].image);
        }
        this.current_obj.projects = this.selected_projects;
        if (this.icons[i].user != 'mazen') {
            this.current_obj.name = 'name to be replaced';
            this.current_obj.title = 'title to be replaced';
            this.current_obj.description = 'description to be replaced';
        }
        else {
          this.current_obj.name = 'MAZEN ALSAWAF';
          this.current_obj.title = 'YOUTEBER AND CONTENT MAKER';
          this.current_obj.description = 'Lorem, ipsum dolor sit amet consectetur adipisicing elit. Placeat nemo non aut veritatis dolores voluptatem vel totam. Quia, blanditiis ipsam magni, voluptas vitae suscipit eius numquam vel impedit dignissimos aspernatur. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Natus temporibus iusto quod enim nobis repellendus saepe laudantium nemo dolor vel totam assumenda, quis fugit unde architecto distinctio tempora sit? Illum.';
        }
        break;
      }
    }
  }
}