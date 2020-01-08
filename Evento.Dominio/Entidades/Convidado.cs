using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.Dominio.Entidades
{
    public  class Convidado : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Email não foi informado");


            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Celular))
                AdicionarCritica("Celular não foi informado");


            if (string.IsNullOrEmpty(Empresa))
                AdicionarCritica("Empresa não foi informado");


            if (string.IsNullOrEmpty(Cargo))
                AdicionarCritica("Cargo não foi informado");
        }
    }
}
