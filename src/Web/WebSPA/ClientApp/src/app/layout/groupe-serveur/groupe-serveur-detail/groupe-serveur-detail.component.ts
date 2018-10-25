import { Component, OnInit, Input } from '@angular/core';
import { GroupeServeurService } from '../groupe-serveur.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IGroupeServeur } from '../../../models/igroupeserveur.model';

@Component({
  selector: 'app-groupe-serveur-detail',
  templateUrl: './groupe-serveur-detail.component.html',
  styleUrls: ['./groupe-serveur-detail.component.scss']
})
export class GroupeServeurDetailComponent implements OnInit {

  groupeserveur: IGroupeServeur = {} as IGroupeServeur;

  constructor(private service: GroupeServeurService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit() {

    this.route.params.subscribe((params) => {
      this.service.get(Number(params.id)).subscribe((x) => {
        this.groupeserveur = x;
      });
    });

  }
  
}
