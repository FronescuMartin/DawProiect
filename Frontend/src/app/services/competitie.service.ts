import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompetitieService {
  private baseUrl = 'http://localhost:7113/api/competitie';

  constructor(private http: HttpClient) { }

  getCompetitie(): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl);
  }
}