﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TarefasMVC.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }
    }
}