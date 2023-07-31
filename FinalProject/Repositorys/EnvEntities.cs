using System;
using System.Collections.Generic;
using FinalProject.Repositorys.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositorys;

public partial class EnvEntities : DbContext
{
    public EnvEntities()
    {
    }

    public EnvEntities(DbContextOptions<EnvEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Reel> Reels { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Instagram;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Post__AA12601898BAAF4D");

            entity.Property(e => e.PostId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Reel>(entity =>
        {
            entity.HasKey(e => e.ReelId).HasName("PK__Reel__1E8232A3CE1DAEDA");

            entity.Property(e => e.ReelId).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4CFF93D9F1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
