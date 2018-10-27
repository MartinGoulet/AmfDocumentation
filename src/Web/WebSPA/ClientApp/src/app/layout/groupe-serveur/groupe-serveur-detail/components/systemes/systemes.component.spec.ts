import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemesComponent } from './systemes.component';

describe('SystemesComponent', () => {
  let component: SystemesComponent;
  let fixture: ComponentFixture<SystemesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
