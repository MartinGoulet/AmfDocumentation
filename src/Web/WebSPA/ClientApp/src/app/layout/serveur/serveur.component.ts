import { Component, OnInit } from '@angular/core';
import { ServeurService } from './serveur.service';

@Component({
  selector: 'app-serveur',
  templateUrl: './serveur.component.html',
  styleUrls: ['./serveur.component.scss']
})
export class ServeurComponent implements OnInit {

  serveurs: Array<any> = [];

  constructor(private service: ServeurService) { }

  ngOnInit() {
    this.service.getAll().subscribe((x) => {
      this.serveurs = x;
    });
  }

}
