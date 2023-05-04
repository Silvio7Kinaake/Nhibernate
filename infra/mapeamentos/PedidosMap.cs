using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNhibernate.entidades;
using FluentNHibernate.Mapping;

namespace AulaNhibernate.infra.mapeamentos
{
    public class PedidosMap: ClassMap<Pedido>
    {
        public PedidosMap()
        {
            Schema("livraria");
            Table ("pedido");
            Id(pedido => pedido.IdPedido).Column("IdPedido");
            Map(pedido => pedido.DataPedido).Column("DataPedido");
            References(pedido => pedido.Cliente).Column("IdCliente");

            // como mapear am relação N para N.
            HasManyToMany(pedido => pedido.Produtos)
            .Table("itempedido")
            .ParentKeyColumn("IdPedido")
            .ChildKeyColumn("IdProduto")
            .Cascade.All();





        }
        
    }
}