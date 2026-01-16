using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KsiazkaTelefoniczna.Models;

namespace KsiazkaTelefoniczna.Data
{
    public class KsiazkaTelefonicznaContext : DbContext
    {
        public KsiazkaTelefonicznaContext (DbContextOptions<KsiazkaTelefonicznaContext> options)
            : base(options)
        {
        }

        public DbSet<KsiazkaTelefoniczna.Models.PhoneBook> PhoneBook { get; set; } = default!;
    }
}
