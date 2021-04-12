using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotesSite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotesSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<NoteModelDto> Notes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
