import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IGroupeServeur } from '../../models/igroupeserveur.model';

@Injectable({ providedIn: 'root' })
export class GroupeServeurService {
    constructor(private httpClient: HttpClient) { }

    getAll(): Observable<IGroupeServeur[]> {
        return this.httpClient.get<IGroupeServeur[]>('http://localhost:5001/api/groupeserveurs');
    }
}
