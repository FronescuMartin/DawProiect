import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersoanaService {
  private baseUrl = 'http://localhost:7113/api/persoana';

  constructor(private http: HttpClient) { }

  getPersoane(): Observable<any[]> {
    return this.http.get<any[]>(this.baseUrl);
  }
}