import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RezultatService {
  private baseUrl = 'http://localhost:7113/api/rezultat';

  constructor(private http: HttpClient) { }

  getRezultate(): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl);
  }
}