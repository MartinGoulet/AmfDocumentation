import { NgModule } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';

import { ServeurRoutingModule } from './serveur-routing.module';
import { ServeurComponent } from './serveur.component';
import { PageHeaderModule } from '../../shared';
import { ServeurDetailComponent } from './serveur-detail/serveur-detail.component';

@NgModule({
    imports: [CommonModule, ServeurRoutingModule, PageHeaderModule, TranslateModule],
    declarations: [ServeurComponent, ServeurDetailComponent]
})
export class ServeurModule {}
