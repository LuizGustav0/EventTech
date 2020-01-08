using Evento.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.Dominio.Contratos
{
    public interface IConvidadoRepositorio : IBaseRepositorio<Convidado>
    {
        Convidado Obter(string email);
    }
}
