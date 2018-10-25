import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupeServeurComponent } from './groupe-serveur.component';

describe('GroupeServeurComponent', () => {
  let component: GroupeServeurComponent;
  let fixture: ComponentFixture<GroupeServeurComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GroupeServeurComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GroupeServeurComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
