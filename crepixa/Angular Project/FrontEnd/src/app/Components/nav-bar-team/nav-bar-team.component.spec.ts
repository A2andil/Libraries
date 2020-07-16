import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavBarTeamComponent } from './nav-bar-team.component';

describe('NavBarTeamComponent', () => {
  let component: NavBarTeamComponent;
  let fixture: ComponentFixture<NavBarTeamComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavBarTeamComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavBarTeamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
