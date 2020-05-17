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
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        public IEnumerable<dynamic> Get()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                var usuario = from user in bd.dados_cliente
                              select new { user.id, user.cpf, user.nome, user.telefone, user.usuario, user.senha, user.cep, user.logradouro, user.complemento, user.bairro, user.cidade, user.uf };
                return usuario.ToList();
            }
            
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public string Post([FromBody]dados_cliente user)
        {
           using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_cliente.Add(user);
                bd.SaveChanges();
                return "Salvo com sucesso";
            }
        }

        // PUT: api/Usuario/5
        public string Put(int id, [FromBody]dados_cliente user)
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                dados_cliente userAlterar = bd.dados_cliente.Find(id);
                userAlterar.cpf = user.cpf;
                userAlterar.nome = user.nome;
                userAlterar.telefone = user.telefone;
                userAlterar.usuario = user.usuario;
                userAlterar.senha = user.senha;
                userAlterar.cep = user.cep;
                userAlterar.logradouro = user.logradouro;
                userAlterar.complemento = user.complemento;
                userAlterar.bairro = user.bairro;
                userAlterar.cidade = user.cidade;
                userAlterar.uf = user.uf;
                bd.SaveChanges();
                return "Salvo com Sucesso";
            }
        }

        // DELETE: api/Usuario/5
        public string Delete(int id)
        {
            using(pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                bd.dados_cliente.Remove(bd.dados_cliente.Find(id));
                bd.SaveChanges();
                return "Removido com sucesso";
            }
            
        }
    }
}
