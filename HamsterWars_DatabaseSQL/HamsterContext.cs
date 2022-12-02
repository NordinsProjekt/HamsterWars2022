using Microsoft.EntityFrameworkCore;
using HamsterWars_DatabaseSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL
{
    public class HamsterContext : DbContext
    {
        public DbSet<Hamster> Hamsters { get; set; }
    }
}
