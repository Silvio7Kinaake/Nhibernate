using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNhibernate.entidades
{
    public class Produto
    {
        public virtual int IdProduto { get; set; }
        public virtual string Descricao{ get; set;}
        public virtual float Preco{ get; set;}

        public Produto()
        {

        }
        public Produto(string descricao, float preco)
        {
            this.Descricao = descricao;
            this.Preco = preco;
        }



        
    }
}