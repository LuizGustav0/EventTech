import { Component, OnInit } from '@angular/core';
import { Convidado } from '../modelo/convidado';
import { ConvidadoServico } from '../servicos/convidado/convidado.servico';


@Component({
  selector: 'app-inscricao',
  templateUrl: './inscricao.component.html',
})
export class InscricaoComponent implements OnInit {
  public convidado: Convidado;
  public mensagem: string;
  public convidadoCadastrado: boolean;
  public ativar_spinner: boolean;
  public sucesso: boolean;

  constructor(private convidadoServico: ConvidadoServico) {

  }

    ngOnInit(): void {
      this.convidado = new Convidado;
  }


  public novaInscricao() {
    this.sucesso = false;
  }

  public cadastrar() {
    this.ativar_spinner = true;
    this.convidadoCadastrado = false;
    this.convidadoServico.CadastrarConvidado(this.convidado)  
      .subscribe(
        usuarioJson => {
          this.convidadoCadastrado = true;
          this.mensagem = "";
          this.sucesso = true;
          this.ativar_spinner = false;
        },
        e => {
          this.mensagem = e.error;
          this.ativar_spinner = false;
         
        }
      );
  }



}
