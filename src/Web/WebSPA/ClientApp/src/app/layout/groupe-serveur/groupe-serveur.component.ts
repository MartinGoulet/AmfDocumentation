import { Component, OnInit } from '@angular/core';
import { GroupeServeurService } from '../../services/groupe-serveur.service';
import { IGroupeServeur } from '../../models/igroupeserveur.model';

@Component({
  selector: 'app-groupe-serveur',
  templateUrl: './groupe-serveur.component.html',
  styleUrls: ['./groupe-serveur.component.scss']
})
export class GroupeServeurComponent implements OnInit {

  groupeserveurs: Array<any> = [];

  constructor(private service: GroupeServeurService) { }

  ngOnInit() {
    this.service.getAll().subscribe((x) => {
      this.groupeserveurs = x;
    });
  }

}
