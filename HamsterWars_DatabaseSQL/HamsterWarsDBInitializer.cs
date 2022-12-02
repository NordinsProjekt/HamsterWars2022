using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterWars_DatabaseSQL.Models;

namespace HamsterWars_DatabaseSQL
{
    public class HamsterWarsDBInitializer : CreateDatabaseIfNotExists<HamsterContext>
    {
        protected override void Seed(HamsterContext context)
        {
            IList<Hamster> defaultStandards = new List<Hamster>();
            base.Seed(context);
        }
    }
}
