import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-testing-api',
  templateUrl: './testing-api.component.html',
  styleUrls: ['./testing-api.component.css']
})
export class TestingApiComponent implements OnInit {

  constructor(private http : HttpClient) { }

  values: any;

  ngOnInit(): void {
    this.getValues();
  }

  getValues() {
    this.http.get('http://localhost:50383/weatherforecast')
    .subscribe(result => {
      this.values = result;
      console.log(this.values);
    }, error => {
      console.log('no');
    });
  }

}
