import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupeServeurDetailComponent } from './groupe-serveur-detail.component';

describe('GroupeServeurDetailComponent', () => {
  let component: GroupeServeurDetailComponent;
  let fixture: ComponentFixture<GroupeServeurDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupeServeurDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupeServeurDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
