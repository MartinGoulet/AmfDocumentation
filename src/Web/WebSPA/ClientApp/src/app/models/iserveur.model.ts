import { IGroupeServeur } from './igroupeserveur.model';

export interface IServeur {
    id: number;
    nom: string;
    domaine: string;
    dateCreation: Date;
    idGroupeServeur: number;
    groupeServeur: IGroupeServeur;
}
