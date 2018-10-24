import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServeurDetailComponent } from './serveur-detail.component';

describe('ServeurDetailComponent', () => {
  let component: ServeurDetailComponent;
  let fixture: ComponentFixture<ServeurDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServeurDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServeurDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
