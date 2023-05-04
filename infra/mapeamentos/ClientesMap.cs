using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNhibernate.entidades;
using FluentNHibernate.Mapping;

namespace AulaNhibernate.infra.mapeamentos
{
    public class ClientesMap : ClassMap<Cliente>
    {
        public ClientesMap()
        {
            Schema("livraria");
            Table ("cliente");
            Id(cliente => cliente.Id).Column("IdCliente");
            Map(cliente => cliente.Email).Column("email");
            Map(cliente => cliente.Nome).Column("nome");
            Map(cliente => cliente.Telefone).Column("telefone");
            Map(cliente => cliente.Endereco).Column("endereco");
            Map(cliente => cliente.Senha).Column("senha");
            //HasMany(cliente => cliente.Pedidos).KeyColumn("IdCliente");


        }
    }
 
}