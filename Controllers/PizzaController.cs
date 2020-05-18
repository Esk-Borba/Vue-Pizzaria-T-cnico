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
    public class PizzaController : ApiController
    {
        // GET: api/Pizza
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var pizza = from pz in bd.dados_pizza
                            select new
                            {
                                pz.id,
                                pz.sabor
                            };
                return pizza.ToList();
            }
        }

        // GET: api/Pizza/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pizza
        public string Post([FromBody]dados_pizza pizza)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_pizza.Add(pizza);
                bd.SaveChanges();
                return "Salvo com sucesso";
            }

        }

        // PUT: api/Pizza/5
        public string Put(int id, [FromBody] dados_pizza pizza)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                dados_pizza userAlterar = bd.dados_pizza.Find(id);
                userAlterar.sabor = pizza.sabor;
                bd.SaveChanges();
                return "Salvo com Sucesso";
            }
        }
        // DELETE: api/Pizza/5
        public string Delete(int id)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_pizza.Remove(bd.dados_pizza.Find(id));
                bd.SaveChanges();
                return "Removido com sucesso";
            }
        }
    }

    
}

