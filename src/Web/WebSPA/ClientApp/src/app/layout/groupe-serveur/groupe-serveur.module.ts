import { NgModule } from '@angular/core';
import { TranslateModule } from '@ngx-translate/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { GroupeServeurRoutingModule } from './groupe-serveur-routing.module';
import { PageHeaderModule } from '../../shared';
import { GroupeServeurComponent } from './groupe-serveur.component';
import { GroupeServeurDetailComponent } from './groupe-serveur-detail/groupe-serveur-detail.component';
import { CategorisationComponent } from './groupe-serveur-detail/components/categorisation/categorisation.component';
import { InformationGeneraleComponent } from './groupe-serveur-detail/components/information-generale/information-generale.component';

@NgModule({
    imports: [CommonModule, GroupeServeurRoutingModule, PageHeaderModule, TranslateModule, ReactiveFormsModule],
    declarations: [GroupeServeurComponent, GroupeServeurDetailComponent, CategorisationComponent, InformationGeneraleComponent]
})
export class GroupeServeurModule {}
