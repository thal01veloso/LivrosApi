export class Assunto {
  assuntoId?: number
  assunto?: {
    descricao: string;
  };
}

export class Autor {
  autorId?: number;
  autor?: {
    nome: string;
  };
}

export class Livro {
  editora?: string;
  edicao?: number;
  anoPublicado?: string;
  livroAssuntos?: Assunto[];
  livroAutores?: Autor[];

}
