using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Sa_pro_chefe.Models;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class BordaController : ApiController
    {
        // GET: api/Borda
        public IEnumerable<dynamic> Get()
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var borda = from bord in bd.dados_borda
                            select new { bord.id, bord.borda, bord.preco_borda };
                return borda.ToList();
            }
        }

        // GET: api/Borda/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Borda
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Borda/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Borda/5
        public void Delete(int id)
        {
        }
    }
}
