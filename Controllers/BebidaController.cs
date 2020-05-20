using System;
using System.Collections.Generic;
using System.Data.Common;
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
                              select new { bebe.id, bebe.tamanho, bebe.bebida, bebe.preco };
                return bebidas.ToList();
            }
        }

        // GET: api/Bebida/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bebida
        public string Post([FromBody]dados_bebida bebida)
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_bebida.Add(bebida);
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
        }

        // PUT: api/Bebida/5
        public string Put(int id, [FromBody]dados_bebida bebida)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                dados_bebida bebidaAlterar = bd.dados_bebida.Find(id);
                bebidaAlterar.bebida = bebida.bebida;
                bebidaAlterar.preco = bebida.preco;
                bebidaAlterar.tamanho = bebida.tamanho;
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
        }

        // DELETE: api/Bebida/5
        public string Delete(int id)
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_bebida.Remove(bd.dados_bebida.Find(id));
                bd.SaveChanges();
                return "Salvo com sucessos";
            }
        }
    }
}
