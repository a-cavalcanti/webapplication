using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastraCaixas.Models
{
    public class CaixaContext : DbContext
    {
        public CaixaContext() : base("Transportadora") //string de conexão
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Caixa> Caixas { get; set; }
    }
}