using AulaNhibernate.entidades;
using AulaNhibernate.infra;
using NHibernate;

internal class Program
{
    private static void Main(string[] args)
    {   
        ISession session = HibernateUtil.getSession();
        ITransaction transaction = session.BeginTransaction();

        
        Pedido pedido = session.Get<Pedido>(5);
        IQueryable<Pedido> query = session.Query<Pedido>();
        query = query.Where(pedido => pedido.Cliente.Nome == "Maria");
        IList<Pedido> pedidos = query.ToList();
        System.Console.WriteLine(pedidos[0].Cliente.Nome);
        transaction.Commit();

        

        /*

       
        Pedido pedido = session.Get<Pedido>(21);
        System.Console.WriteLine(pedido.Produtos[43].Descricao);
        System.Console.WriteLine(pedido.Produtos[44].Descricao);
        System.Console.WriteLine(pedido.Produtos[45].Descricao);

        transaction.Commit();
        */
    


       /*
       

        Produto produto4 = new Produto ("Moclila", 69.50f);
        Produto produto5 = new Produto ("Apontador", 5.15f);
        Produto produto6 = new Produto ("Mouse", 20.60f);

        IList<Produto> produtos = new List<Produto>();

        produtos.Add(produto4);
        produtos.Add(produto5);
        produtos.Add(produto6);

        session.Save(produto4);
        session.Save(produto5);
        session.Save(produto6);

        Cliente cliente = session.Get<Cliente>(1);

        Pedido pedido = new Pedido(cliente,produtos);
        session.Save(pedido);

        transaction.Commit();
        */
        


        //     2 º Tabela Pedido

        //    Gerar pedido
        //ISession session = HibernateUtil.getSession();
        //ITransaction transaction = session.BeginTransaction();
        //Cliente cliente = session.Get<Cliente>(1);
        //Pedido pedido = new Pedido(cliente);
        //session.Save(pedido);
        //transaction.Commit();
             
        //     Consultar Pedido e em listas
        //ISession session = HibernateUtil.getSession();
        //ITransaction transaction = session.BeginTransaction();
        ///Cliente cliente = session.Get<Cliente>(1);
        ///System.Console.WriteLine(cliente.Pedidos[0].IdPedido);
        ///System.Console.WriteLine(cliente.Pedidos[1].IdPedido);
        ///transaction.Commit();




                // 1º Tabela Cliente

        // 1 ISession session = HibernateUtil.getSession();
        // 1 Cliente cliente = new Cliente("Antônio ", "antonio@gmail.com ","21 88345 7711 ","Rua 30 ","Teste33369");
        // 1 session.Save(cliente);
        
        // Inserir 2 - ISession session = HibernateUtil.getSession();
        // Inserir 2 - Cliente cliente = new Cliente("Beltraono ", "beltraono@gmail.com ","27 12345 6799 ","Rua A ","teste987");
        // Inserir 2 - System.Console.WriteLine((int)session.Save(cliente));
        
        // Pegar 3 - ISession session = HibernateUtil.getSession();
        // Pegar 3 - Cliente cliente = session.Get<Cliente>(1);
        // pegar 3 - System.Console.WriteLine(cliente.Nome);
        
        // 4- Alterar e Deletar Obs: enable projeto SDK  para seguir;
        // 4 - ISession session = HibernateUtil.getSession();
        //4- ITransaction transaction = session.BeginTransaction();
        //4- Cliente cliente = session.Get<Cliente>(2);
        //4- cliente.Nome = "Ciclano";
        //4- cliente.Email = "ciclano@gmail.com";
        //4- session.Update(cliente);
        //4- transaction.Commit();

        //5 - ISession session = HibernateUtil.getSession();
        //5- ITransaction transaction = session.BeginTransaction();
        //5- Cliente cliente = session.Get<Cliente>(2);
        //5 - session.Delete(cliente);
        //5- transaction.Commit();

    }
}