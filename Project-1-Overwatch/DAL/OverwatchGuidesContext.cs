using Project_1_Overwatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_1_Overwatch.DAL
{
    public class OverwatchGuidesContext : DbContext
    {
        public OverwatchGuidesContext() : base("OverwatchGuidesContext")
        {

        }

        public DbSet<Hero> Heroes { get; set; }
    }
}