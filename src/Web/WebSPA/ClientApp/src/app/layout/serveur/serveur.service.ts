import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IServer } from '../../models/iserver.model';

@Injectable({providedIn: 'root'})
export class ServeurService {
    constructor(private httpClient: HttpClient) { }

    getAll() : Observable<IServer[]> {
        return this.httpClient.get<IServer[]>('http://localhost:5001/api/serveurs');
    }
}