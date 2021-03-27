using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Context
{
    public class SmartphoneContext : DbContext
    {
        public SmartphoneContext(DbContextOptions<SmartphoneContext> opt) : base (opt)
        {}


    }
}
