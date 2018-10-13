using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

using System.Text;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace WarsztatyCore
{
    public class DataContext:DbContext
    {

        public virtual DbSet<ContactModel> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CodeAndCloud;Trusted_Connection=true;");
        }

       

    }
}
