import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-gs-information-generale',
  templateUrl: './information-generale.component.html'
})
export class InformationGeneraleComponent implements OnInit {

  @Input()
  public groupeServeurForm: FormGroup;

  constructor() { }

  ngOnInit() {
  }

}
