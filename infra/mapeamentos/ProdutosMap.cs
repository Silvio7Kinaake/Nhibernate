using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNhibernate.entidades;
using FluentNHibernate.Mapping;

namespace AulaNhibernate.infra.mapeamentos
{
    public class ProdutosMap: ClassMap<Produto>
    {   public ProdutosMap()
        { 
            Schema("livraria");
            Table("produto");
            Id(produto => produto.IdProduto).Column("IdProduto");
            Map(produto => produto.Descricao).Column("Descricao");
            Map(produto => produto.Preco).Column("Preco");





        }
            
    }
}