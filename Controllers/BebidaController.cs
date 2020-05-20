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
<<<<<<< HEAD
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
=======
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
>>>>>>> caa0d7054ada6c5d298bac4f7838842a3946552c
            {
                bd.dados_bebida.Add(bebida);
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
<<<<<<< HEAD
        }
=======
>>>>>>> caa0d7054ada6c5d298bac4f7838842a3946552c

        }
        // PUT: api/Bebida/5
        public string Put(int id, [FromBody]dados_bebida bebida)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                dados_bebida bebidaAlterar = bd.dados_bebida.Find(id);
                bebidaAlterar.bebida = bebida.bebida;
<<<<<<< HEAD
                bebidaAlterar.preco = bebida.preco;
                bebidaAlterar.tamanho = bebida.tamanho;
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
=======
                bebidaAlterar.tamanho = bebida.tamanho;
                bebidaAlterar.preco = bebida.preco;
                bd.SaveChanges();
                return "Salvo com sucesso";
            }

>>>>>>> caa0d7054ada6c5d298bac4f7838842a3946552c
        }

        // DELETE: api/Bebida/5
        public string Delete(int id)
        {
<<<<<<< HEAD
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_bebida.Remove(bd.dados_bebida.Find(id));
                bd.SaveChanges();
                return "Salvo com sucessos";
            }
=======
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_bebida.Remove(bd.dados_bebida.Find(id));
                bd.SaveChanges();
                return "Removido com sucesso";
            }

>>>>>>> caa0d7054ada6c5d298bac4f7838842a3946552c
        }
    }
}
