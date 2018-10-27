import { Component, OnInit, Input } from '@angular/core';
import { Validators, FormGroup, FormArray, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { GroupeServeurService } from '../../../services/groupe-serveur.service';
import { IGroupeServeur } from '../../../models/igroupeserveur.model';

@Component({
  selector: 'app-groupe-serveur-detail',
  templateUrl: './groupe-serveur-detail.component.html'
})
export class GroupeServeurDetailComponent implements OnInit {

  groupeserveur: IGroupeServeur = {} as IGroupeServeur;

  myForm: FormGroup;

  constructor(private service: GroupeServeurService,
    private route: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder) { }

  ngOnInit() {

    this.route.params.subscribe((params) => {
      this.service.get(Number(params.id)).subscribe((x) => {
        this.groupeserveur = x;
        this.creerFormulaire(x);
      });
    });

  }

  creerFormulaire(gs : IGroupeServeur) {

    this.myForm = this.fb.group({
      description: [gs.description, [Validators.required, Validators.minLength(5), Validators.maxLength(200)]],
      categorie: [gs.categorie, [Validators.required]],
      numero: [gs.numero, [Validators.required]],
      zone: [gs.zone, [Validators.required, Validators.minLength(3), Validators.maxLength(5)]]
    });

  }

  enregistrer(fg: FormGroup) {
    let value : IGroupeServeur = Object.assign(this.groupeserveur, fg.getRawValue());
    alert(JSON.stringify(value));
    fg.markAsPristine();
  }

}
