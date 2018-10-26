import { Component, OnInit, Input } from '@angular/core';
import { IGroupeServeur } from '../../../../../models/igroupeserveur.model';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-gs-categorisation',
  templateUrl: './categorisation.component.html'
})
export class CategorisationComponent implements OnInit {

  @Input()
  public groupeServeurForm: FormGroup;

  constructor() { }

  ngOnInit() {
  }

}
