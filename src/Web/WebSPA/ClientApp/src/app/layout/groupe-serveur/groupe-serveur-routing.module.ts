import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GroupeServeurComponent } from './groupe-serveur.component';
import { GroupeServeurDetailComponent } from './groupe-serveur-detail/groupe-serveur-detail.component';

const routes: Routes = [
    { path: '', component: GroupeServeurComponent },
    { path: ':id', component: GroupeServeurDetailComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class GroupeServeurRoutingModule { }
