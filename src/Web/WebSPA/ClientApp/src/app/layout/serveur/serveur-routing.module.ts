import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ServeurComponent } from './serveur.component';
import { ServeurDetailComponent } from './serveur-detail/serveur-detail.component';

const routes: Routes = [
    { path: '', component: ServeurComponent },
    { path: ':id', component: ServeurDetailComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ServeurRoutingModule { }
