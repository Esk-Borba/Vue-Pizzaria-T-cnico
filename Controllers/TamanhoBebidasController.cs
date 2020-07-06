using Sa_pro_chefe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class TamanhoBebidasController : ApiController
    {
        // GET: api/TamanhoBebidas
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var tamanhoPrecoBebidas = from tamanho in bd.preco_bebidas
                              select new { tamanho.id, tamanho.tamanho, tamanho.preco };
                return tamanhoPrecoBebidas.ToList();
            }
        }

        // GET: api/TamanhoBebidas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TamanhoBebidas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TamanhoBebidas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TamanhoBebidas/5
        public void Delete(int id)
        {
        }
    }
}
