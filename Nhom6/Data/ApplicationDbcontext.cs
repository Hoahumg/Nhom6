using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nhom6.Models;

namespace Nhom6.Data;
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }
        public DbSet<Nhom6.Models.Dangnhap> Dangnhap { get; set; } = default!;

    }
