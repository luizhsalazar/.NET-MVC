using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using Aula1_MVC.Models;

namespace Aula1_MVC.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context()
            : base("Aula1Context")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}