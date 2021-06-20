﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsDemo.Data
{
    public class DbContexto:DbContext 
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }

        public DbSet<StudentsClasse> students { get; set; }
    }
}
