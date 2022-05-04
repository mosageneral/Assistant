#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssistantApp.Models;

    public class DB : DbContext
    {
        public DB (DbContextOptions<DB> options)
            : base(options)
        {
        }

        public DbSet<AssistantApp.Models.Appointment> Appointment { get; set; }
    }
