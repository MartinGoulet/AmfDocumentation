import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IServeur } from '../../models/iserveur.model';

@Injectable({ providedIn: 'root' })
export class ServeurService {
    constructor(private httpClient: HttpClient) { }

    getAll(): Observable<IServeur[]> {
        return this.httpClient.get<IServeur[]>('http://localhost:5001/api/serveurs');
    }

    getLastAdded(): Observable<IServeur[]> {
        return this.httpClient.get<IServeur[]>('http://localhost:5001/api/serveurs/getlastadded/5');
    }
}
