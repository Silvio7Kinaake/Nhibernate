using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulaNhibernate.infra.mapeamentos;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace AulaNhibernate.infra
{
    public class HibernateUtil
    {
        public static ISessionFactory? sessionFactory;

        public static ISession getSession()
        {
            sessionFactory = Fluently.Configure().Database(
            MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=livraria;Uid=root;Pwd=")
            .ShowSql()
            .FormatSql())
            .Mappings(m=> {m.FluentMappings.AddFromAssemblyOf<ClientesMap>();})
            .BuildSessionFactory();
            

            return sessionFactory.OpenSession();
            
        }

    }
}