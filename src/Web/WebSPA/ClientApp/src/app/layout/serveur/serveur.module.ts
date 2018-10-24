import { NgModule } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';

import { ServeurRoutingModule } from './serveur-routing.module';
import { ServeurComponent } from './serveur.component';
import { PageHeaderModule } from '../../shared';

@NgModule({
    imports: [CommonModule, ServeurRoutingModule, PageHeaderModule, TranslateModule],
    declarations: [ServeurComponent]
})
export class ServeurModule {}
