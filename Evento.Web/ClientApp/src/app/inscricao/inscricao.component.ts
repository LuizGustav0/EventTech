import { Component, OnInit } from '@angular/core';
import { Convidado } from '../modelo/convidado';

@Component({
  selector: 'app-inscricao',
  templateUrl: './inscricao.component.html',
})
export class InscricaoComponent implements OnInit {
  public convidado: Convidado;

    ngOnInit(): void {
      this.convidado = new Convidado;
    }

}
