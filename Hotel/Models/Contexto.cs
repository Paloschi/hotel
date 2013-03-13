using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Hotel.Models.poco;

namespace Hotel.Models 
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Checkin> Checkins { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<StatusQuarto> StatusQuartos { get; set; }
    }
}