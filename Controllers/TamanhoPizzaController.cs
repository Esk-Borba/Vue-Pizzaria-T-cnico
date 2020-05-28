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
    public class TamanhoPizzaController : ApiController
    {
        // GET: api/TamanhoPizza
        public IEnumerable<dynamic> Get()
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var tamanho = from tam in bd.dados_pizza_tamanho
                              select new { tam.id, tam.tamanho, tam.preco_tamanho };
                return tamanho.ToList();
            }
        }

        // GET: api/TamanhoPizza/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TamanhoPizza
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TamanhoPizza/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TamanhoPizza/5
        public void Delete(int id)
        {
        }
    }
}
