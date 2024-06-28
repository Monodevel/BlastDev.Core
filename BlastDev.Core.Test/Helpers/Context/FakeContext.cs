using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BlastDev.Core.Test.Helpers.Context
{
    public class FakeContext : DbContext
    {
        protected FakeContext() { }

        public FakeContext([NotNull] DbContextOptions options) : base(options) { }

        public DbSet<FakeEntity> FakeEntity { get; set; }
    }
}
