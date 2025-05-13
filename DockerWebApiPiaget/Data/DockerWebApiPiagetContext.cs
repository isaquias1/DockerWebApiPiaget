using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DockerWebApiPiaget.Data
{
    public class DockerWebApiPiagetContext : DbContext
    {
        public DockerWebApiPiagetContext (DbContextOptions<DockerWebApiPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Aluno> Aluno { get; set; } = default!;
    }
}
