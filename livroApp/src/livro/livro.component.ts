import { Component, OnInit } from '@angular/core';
import { ServiceComponent } from 'src/service/service.component';

@Component({
  selector: 'app-livro',
  templateUrl: './livro.component.html',
  styleUrls: ['./livro.component.css']
})
export class LivroComponent implements OnInit {
  livros: Array<any> = new Array();

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

}
