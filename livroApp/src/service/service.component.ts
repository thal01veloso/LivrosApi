import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, map } from 'rxjs';
import { Injectable } from '@angular/core';
import { Assunto, Autor, Livro } from 'src/models/livroRequest';

@Component({
  selector: 'app-service',
  templateUrl: './service.component.html',
  styleUrls: ['./service.component.css']
})

@Injectable({
  providedIn: 'root', // or 'any' if you want to provide it elsewhere
})
export class ServiceComponent {
  constructor(private http: HttpClient, private router:Router) { }

  listarTodos():Observable<any>{
     let response = this.http.get("https://localhost:62701/livro");
     return response
  }

  cadastrar(livro: Livro, assunto: Assunto, autor: Autor): Observable<any> {
    livro.livroAssuntos?.push(assunto);
    livro.livroAutores?.push(autor);
    return this.http.post("http://localhost:62701/livro", livro).pipe(
      map((response: any) => {
        return response; // Retornar a resposta da requisição
      })
    );
  }
}
