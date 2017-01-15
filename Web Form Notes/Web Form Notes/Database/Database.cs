namespace Learn_Web_Forms.Database {
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class Database : DbContext {
    public Database()
        : base("name=Database1") {
    }

    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<Note> Notes { get; set; }
    public virtual DbSet<Quote> Quotes { get; set; }
    public virtual DbSet<QuoteLine> QuoteLines { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Entity<Company>()
          .Property(e => e.Name)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Address)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.City)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.State)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Zip)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .Property(e => e.Phone)
          .IsUnicode(false);

      modelBuilder.Entity<Company>()
          .HasMany(e => e.Contacts)
          .WithRequired(e => e.Company)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Company>()
          .HasMany(e => e.Quotes)
          .WithRequired(e => e.Company)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Name)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Position)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Phone)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Email)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .Property(e => e.Details)
          .IsUnicode(false);

      modelBuilder.Entity<Contact>()
          .HasMany(e => e.Notes)
          .WithRequired(e => e.Contact)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Note>()
          .Property(e => e.Title)
          .IsUnicode(false);

      modelBuilder.Entity<Note>()
          .Property(e => e.Text)
          .IsUnicode(false);

      modelBuilder.Entity<Quote>()
          .Property(e => e.Name)
          .IsUnicode(false);

      modelBuilder.Entity<Quote>()
          .HasMany(e => e.QuoteLines)
          .WithRequired(e => e.Quote)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<QuoteLine>()
          .Property(e => e.DESC)
          .IsUnicode(false);

      modelBuilder.Entity<QuoteLine>()
          .Property(e => e.UNIT)
          .IsUnicode(false);
    }
  }
}
