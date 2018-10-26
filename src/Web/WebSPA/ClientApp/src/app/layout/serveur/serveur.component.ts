import { Component, OnInit } from '@angular/core';
import { ServeurService } from '../../services/serveur.service';
import { IGroupeServeur } from '../../models/igroupeserveur.model';

@Component({
  selector: 'app-serveur',
  templateUrl: './serveur.component.html',
  styleUrls: ['./serveur.component.scss']
})
export class ServeurComponent implements OnInit {

  serveurs: Array<any> = [];

  constructor(private service: ServeurService, 
) { }

  ngOnInit() {
    this.service.getLastAdded().subscribe((x) => {
      this.serveurs = x;
    });
  }

  afficherGroupeServeur(gs: IGroupeServeur) {
    return gs ? gs.nom : '';
  }

}
