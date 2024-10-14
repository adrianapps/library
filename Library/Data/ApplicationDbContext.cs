using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<BookFile> BookFiles { get; set; }
    public DbSet<Borrow> Borrows { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Borrow>()
            .HasOne(b => b.Book)
            .WithMany(bk => bk.Borrows)
            .HasForeignKey(b => b.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Borrow>()
            .HasOne(b => b.User)
            .WithMany(u => u.Borrows)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}