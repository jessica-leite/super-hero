import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Hero } from '../models/hero';

@Injectable({
  providedIn: 'root',
})
export class HeroService {
  private apiUrl = `${environment.apiUrl}/api/Heros`;

  constructor(private http: HttpClient) { }

  getHeros(): Observable<Hero[]> {
    return this.http.get<Hero[]>(this.apiUrl);
  }

  getHero(id: number): Observable<Hero> {
    return this.http.get<Hero>(`${this.apiUrl}/${id}`);
  }

  createHero(Hero: Hero): Observable<Hero> {
    return this.http.post<Hero>(this.apiUrl, Hero);
  }

  updateHero(id: number, Hero: Hero): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}`, Hero);
  }

  deleteHero(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
