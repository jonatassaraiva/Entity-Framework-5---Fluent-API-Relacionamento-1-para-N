using EntityFramewor5CodeFristFluentAPI.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramewor5CodeFristFluentAPI.Repositorio
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapeamento Blog
            // Primary Key
            modelBuilder.Entity<Blog>().HasKey(b => b.Id);
            // Properties
            modelBuilder.Entity<Blog>().Property(b => b.Nome)
                .HasMaxLength(200);
            // Table & Column Mappings
            modelBuilder.Entity<Blog>().ToTable("Blogs");
            modelBuilder.Entity<Blog>().Property(t => t.Id).HasColumnName("Id");
            modelBuilder.Entity<Blog>().Property(t => t.Nome).HasColumnName("Nome");

            // Mapeamento Post
            // Primary Key
            modelBuilder.Entity<Post>().HasKey(p => p.Id);
            // Properties
            modelBuilder.Entity<Post>().Property(p => p.Titulo)
                .HasMaxLength(200);
            // Table & Column Mappings
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Post>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Post>().Property(p => p.Titulo).HasColumnName("Titulo");
            modelBuilder.Entity<Post>().Property(p => p.Conteudo).HasColumnName("Conteudo");
            // Relationships
            modelBuilder.Entity<Post>().HasRequired(p => p.Blog)
                .WithMany(b => b.Posts)
                .Map(m =>
                {
                    m.MapKey("BlogId");
                });
        }
    }
}
