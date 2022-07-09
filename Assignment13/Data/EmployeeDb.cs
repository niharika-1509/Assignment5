using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment13.Models;

namespace Assignment13.Data
{
    public class EmployeeDb : DbContext
    {
        public EmployeeDb (DbContextOptions<EmployeeDb> options)
            : base(options)
        {
        }

        public DbSet<Assignment13.Models.Employee> Employee { get; set; }
    }
}
