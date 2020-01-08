using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evento.Dominio.Contratos;
using Evento.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Evento.Web.Controllers 
{
    [Route("api/[Controller]")]
    public class ConvidadoController : Controller
    {
        private readonly IConvidadoRepositorio _convidadoRepositorio;

        public ConvidadoController(IConvidadoRepositorio convidadoRepositorio)
        {
            _convidadoRepositorio = convidadoRepositorio;
        }



        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public ActionResult Post([FromBody] Convidado convidado)
        {
            try
            {
                var usuarioCadastrado = _convidadoRepositorio.Obter(convidado.Email);

                if (usuarioCadastrado != null)
                {
                    return BadRequest("Aparentemente você já inscrito, enviaremos novamente o email de confirmação junto com seu QR code");                   
                }
                _convidadoRepositorio.Adicionar(convidado);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
