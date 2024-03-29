﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
