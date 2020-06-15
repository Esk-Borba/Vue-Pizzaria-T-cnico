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
    public class PedidoController : ApiController
    {
        // GET: api/Pedido
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var pedidos = from ped in bd.entregas
                              select new { ped.id, ped.bebida, ped.borda, ped.id_cliente, ped.cliente, ped.sabor1, ped.sabor2, ped.sabor3, ped.sabor4, ped.formaPagamento };
                return pedidos.ToList();
            }
        }

        // GET: api/Pedido/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pedido
        public string Post([FromBody]entregas entrega)
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.entregas.Add(entrega);
                bd.SaveChanges();
                return "Salvo com Sucesso";
            }
        }

        // PUT: api/Pedido/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pedido/5
        public void Delete(int id)
        {
        }
    }
}
