using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Zadanie4
{
        public class TPHKontekst : DbContext
        {
            public DbSet<Osoba> Osoby { get; set; }

        }

}
