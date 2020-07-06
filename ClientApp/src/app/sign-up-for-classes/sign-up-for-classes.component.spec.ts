import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SignUpForClassesComponent } from './sign-up-for-classes.component';

describe('SignUpForClassesComponent', () => {
  let component: SignUpForClassesComponent;
  let fixture: ComponentFixture<SignUpForClassesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SignUpForClassesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SignUpForClassesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
