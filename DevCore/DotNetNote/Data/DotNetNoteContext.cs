using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetNote.Models;

namespace DotNetNote.Data
{
    public class DotNetNoteContext : DbContext
    {
        public DotNetNoteContext (DbContextOptions<DotNetNoteContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetNote.Models.Data> Data { get; set; }
    }
}
