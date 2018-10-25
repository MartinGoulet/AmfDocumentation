import { NgModule } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';

import { GroupeServeurRoutingModule } from './groupe-serveur-routing.module';
import { PageHeaderModule } from '../../shared';
import { GroupeServeurComponent } from './groupe-serveur.component';
import { GroupeServeurDetailComponent } from './groupe-serveur-detail/groupe-serveur-detail.component';

@NgModule({
    imports: [CommonModule, GroupeServeurRoutingModule, PageHeaderModule, TranslateModule],
    declarations: [GroupeServeurComponent, GroupeServeurDetailComponent]
})
export class GroupeServeurModule {}
