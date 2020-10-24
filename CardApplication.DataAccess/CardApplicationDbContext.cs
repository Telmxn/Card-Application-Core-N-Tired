using CardApplication.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication.DataAccess
{
    public class CardApplicationDbContext : DbContext
    {
        public CardApplicationDbContext(DbContextOptions<CardApplicationDbContext> options) : base(options) { }
        public DbSet<Card> Cards { get; set; }
    }
}
