using Sa_pro_chefe.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class FormaPagamentoController : ApiController
    {
        // GET: api/FormaPagamento
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var formaPagamento = from formPag in bd.pagamento
                                     select new { formPag.id, formPag.tipo_pagamento };
                return formaPagamento.ToList();
            }
        }

        // GET: api/FormaPagamento/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FormaPagamento
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FormaPagamento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FormaPagamento/5
        public void Delete(int id)
        {
        }
    }
}
