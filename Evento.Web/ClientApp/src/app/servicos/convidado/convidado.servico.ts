import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Convidado } from "../../modelo/convidado";

@Injectable({
  providedIn: "root"
})
export class ConvidadoServico {

  private baseURL: string;
  private _convidado: Convidado;


  //set Convidado(convidado: Convidado) {
  //  sessionStorage.setItem("Convidado-autenticado", JSON.stringify(convidado));
  //  this._Convidado = convidado;
  //}

  //get convidado(): Convidado {
  //  let convidado_json = sessionStorage.getItem("Convidado-autenticado");
  //  this._convidado = JSON.parse(convidado_json);
  //  return this._Convidado;
  //}

  //public limpar_sessao() {
  //  sessionStorage.setItem("Convidado-autenticado", "");
  //  this._Convidado = null;
  //}

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  //public verificarConvidado(Convidado: Convidado): Observable<Convidado> {

  //  return this.http.post<Convidado>(this.baseURL + "api/Convidado/VerificarConvidado", JSON.stringify(Convidado), { headers: this.headers });
  //}


  public CadastrarConvidado(convidado: Convidado): Observable<Convidado> {
    return this.http.post<Convidado>(this.baseURL + "api/Convidado/", JSON.stringify(convidado), { headers: this.headers });
  }


}
