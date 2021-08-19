import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';

import { Kategori } from './domain';

@Injectable({
  providedIn: 'root'
})
export class KategoriService {
  apiUrl: string = "https://localhost:5001/api/kategori";

  httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  };

  constructor(
    private http:HttpClient
  ) { }

  getKategoris(): Observable<Kategori[]>{
    return this.http.get<Kategori[]>(this.apiUrl);
  }

  getKategori(id:number): Observable<Kategori>{
    return this.http.get<any>(`${this.apiUrl}/${id}`).pipe(
      catchError(this.handleError<any>('GetOneKategori'))
    )};


  addkategori(kategori: Kategori): Observable<Kategori> {
    return this.http.post<Kategori>(this.apiUrl, kategori, this.httpOptions).pipe(
      catchError(this.handleError<Kategori>('addkategori'))
    );
  }

  updateKategori(kategori: Kategori): Observable<Kategori>{
    return this.http.put<Kategori>(`${this.apiUrl}/${kategori.id}`, kategori ,this.httpOptions)
      .pipe(catchError(this.handleError<any>('updateKategori')));
  }

  deleteKategori(id: Number): Observable<Kategori>{
    return this.http.delete<Kategori>(`${this.apiUrl}/${id}`)
      .pipe(
        catchError(this.handleError<any>('deleteKategori'))
      );
  }

   /**
    * Handle Http operation that failed.
    * Let the app continue.
    * @param operation - name of the operation that failed
    * @param result - optional value to return as the observable result
    */
    private handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {
         // TODO: send the error to remote logging infrastructure
         console.error(error); // log to console instead
  
         // TODO: better job of transforming error for user consumption
         console.log(`${operation} failed: ${error.message}`);
  
         // Let the app keep running by returning an empty result.
         return of(result as T);
      };
   }
}
