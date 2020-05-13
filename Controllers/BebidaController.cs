using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Sa_pro_chefe.Models;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class BebidaController : ApiController
    {
        // GET: api/Bebida
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var bebidas = from bebe in bd.dados_bebida
                              select new { bebe.id, bebe.tamanho, bebe.tipo, bebe.sabor, bebe.preco };
                return bebidas.ToList();
            }
        }

        // GET: api/Bebida/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bebida
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bebida/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bebida/5
        public void Delete(int id)
        {
        }
    }
}
