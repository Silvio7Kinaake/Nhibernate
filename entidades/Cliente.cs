using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaNhibernate.entidades
{
    public class Cliente
    {
        public virtual int Id {get; set;}

        public virtual string Nome { get; set; }

        public virtual string Email { get; set; }
        public virtual string Telefone { get; set; }

        public virtual string Endereco { get; set; }

        public virtual string Senha { get; set; }
        //public virtual IList<Pedido> Pedidos{get; set;}

        public Cliente(){
            
        }

        public Cliente(string nome, string email, string telefone, string endereco, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Senha = senha;

        }

    }
}