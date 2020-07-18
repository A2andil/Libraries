import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionaireHeaderComponent } from './questionaire-header.component';

describe('QuestionaireHeaderComponent', () => {
  let component: QuestionaireHeaderComponent;
  let fixture: ComponentFixture<QuestionaireHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestionaireHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestionaireHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
