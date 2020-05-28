using Sa_pro_chefe.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class EntregadorController : ApiController
    {
        // GET: api/Entregador
        public IEnumerable<dynamic> Get()
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var entregador = from entreg in bd.entregador
                                 select new { entreg.id, entreg.codigo, entreg.nome, entreg.tipo_usuario, entreg.disponibilidade, entreg.usuario, entreg.senha };
                return entregador.ToList();
            }
        }

        // GET: api/Entregador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Entregador
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Entregador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Entregador/5
        public void Delete(int id)
        {
        }
    }
}
