using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksByHalim.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksByHalim.Data
{
    public class BookDbContext : DbContext
    {

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

    }
}
