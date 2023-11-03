import { Component, OnInit } from '@angular/core';
import { Assunto, Autor, Livro } from 'src/models/livroRequest';
import { ServiceComponent } from 'src/service/service.component';

@Component({
  selector: 'app-livro',
  templateUrl: './livro.component.html',
  styleUrls: ['./livro.component.css']
})
export class LivroComponent implements OnInit {
  livros: Array<any> = new Array();
  livro: Livro = new Livro()
  autor: Autor = new Autor()
  assunto: Assunto = new Assunto()

  constructor(private service :ServiceComponent) { }
  ngOnInit(): void {
    console.log("Chegou aqui")
    debugger;
    this.listarProdutos();
  }

  listarProdutos(){
    this.service.listarTodos().subscribe(livros=>{
      this.livros=livros
    }, err=>{
      console.log("livros",err)
    })
  }
  cadastrarLivro(){
    this.service.cadastrar(this.livro, this.assunto, this.autor).subscribe((livroModificado) => {
      console.log('Livro cadastrado com sucesso', livroModificado);
    }, (error) => {
      console.log('Erro no cadastro', error);
    });

  }

}
