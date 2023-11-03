export class Assunto {
  assuntoId?: number=0
  assunto?: any ={};
}

export class Autor {
  autorId?: number=0;
  autor?: any ={};
}

export class Livro {
  editora?: string;
  edicao?: number;
  anoPublicado?: string;
  livroAssuntos?: Assunto[] = [];
  livroAutores?: Autor[] = [];

}

