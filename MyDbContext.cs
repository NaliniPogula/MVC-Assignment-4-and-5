using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Entity;

namespace HOL_4.Models
{
    public class MyDbContext : System.Data.Entity.DbContext
    {
        public MyDbContext()
            : base("name=conn")
        {

        }
        public System.Data.Entity.DbSet<Account> Accounts { get; set; }
    }
}