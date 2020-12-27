using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaAppVS.Models;

namespace MinhaAppVS.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            : base(options)
        {

        }
        public DbSet<MinhaAppVS.Models.Pessoa> Pessoa { get; set; }
        public DbSet<MinhaAppVS.Models.Filme> Filme { get; set; }
        public DbSet<MinhaAppVS.Models.CadastrarUsuario> CadastrarUsuarios { get; set; }
    }
}
