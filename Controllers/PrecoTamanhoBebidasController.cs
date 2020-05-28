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
    public class PrecoTamanhoBebidasController : ApiController
    {
        // GET: api/PrecoTamanhoBebidas
        public IEnumerable<dynamic> Get()
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var tamanhoPreco = from tamPreco in bd.preco_bebidas
                                   select new { tamPreco.id, tamPreco.preco, tamPreco.tamanho };
                return tamanhoPreco.ToList();
            }
        }

        // GET: api/PrecoTamanhoBebidas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PrecoTamanhoBebidas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PrecoTamanhoBebidas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PrecoTamanhoBebidas/5
        public void Delete(int id)
        {
        }
    }
}
