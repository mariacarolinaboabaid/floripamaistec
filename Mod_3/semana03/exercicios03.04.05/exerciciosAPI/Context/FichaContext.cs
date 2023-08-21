using exerciciosAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace exerciciosAPI.Context
{
    public class FichaContext : DbContext
    {
        
        public FichaContext(DbContextOptions options) : base(options)
        { 
            // SQLitePCL.Batteries.Init();
        }

        public DbSet<FichaModel> FichaModels { get; set; }
        public DbSet<DetalheModel> DetalheModels { get; set; }
        public DbSet<TelefoneModel> TelefoneModels { get; set; }

        // Declaração dos relacionamentos entre os modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Detalhes)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;

            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Telefones)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;
            
            modelBuilder.Entity<DetalheModel>()
                        .Property(p => p.DataCadastro)
                        .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<FichaModel>()
                        .Property(p => p.DataCadastro)
                        .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<FichaModel>()
                        .HasData(
                            new FichaModel{Id = 1, Nome = "Maria Boabaid", Email = "carolkboabaid@gmail.com", DataNascimento = new DateTime(1997, 10, 14)},

                            new FichaModel{Id = 2, Nome = "Alexandre Nolla", Email = "alexandrenolla@gmail.com", DataNascimento = new DateTime(1995, 10, 14)},

                            new FichaModel{Id = 3, Nome = "Henrique Nolla", Email = "henriquenolla@gmail.com", DataNascimento = new DateTime(1994, 12, 10)},

                            new FichaModel{Id = 4, Nome = "Fernanda Silva", Email = "fernandasilva@gmail.com", DataNascimento = new DateTime(1992, 03, 03)},
                            
                            new FichaModel{Id = 5, Nome = "Gabriel Sousa", Email = "gabrielsousa@gmail.com", DataNascimento = new DateTime(1990, 01, 02)},
                            
                            new FichaModel{Id = 6, Nome = "Otto Knudsen", Email = "ottoknudsen@gmail.com", DataNascimento = new DateTime(1997, 08, 08)},
                            
                            new FichaModel{Id = 7, Nome = "Sofia Tunner", Email = "sofiatunner@gmail.com", DataNascimento = new DateTime(1995, 04, 04)},
                            
                            new FichaModel{Id = 8, Nome = "Daniel Wisser", Email = "danielwisser@gmail.com", DataNascimento = new DateTime(1993, 07, 27)},
                            
                            new FichaModel{Id = 9, Nome = "Luiza Gonçalves", Email = "luizagoncalves@gmail.com", DataNascimento = new DateTime(1990, 06, 10)},
                            
                            new FichaModel{Id = 10, Nome = "Maria Eugenia Silvester", Email = "mariaeugeniasilvester@gmail.com", DataNascimento = new DateTime(1998, 02, 14)});

            modelBuilder.Entity<DetalheModel>()
                        .HasData(
                            new DetalheModel{Id = 1, FeedBack = "Maravilhoso", Nota = Enum.EnumNota.Cinco, Ativo = true, FichaId = 1 },
                            new DetalheModel{Id = 2, FeedBack = "Ótimo!", Nota = Enum.EnumNota.Quatro, Ativo = true , FichaId = 2}
                        );

            modelBuilder.Entity<TelefoneModel>()
                        .HasData(
                            new TelefoneModel{Id = 1, DDD = "048", Numero = "999337729", Ativo = true, FichaId = 1},
                            new TelefoneModel{Id = 2, DDD = "048", Numero = "999448899", Ativo = true, FichaId = 2}
                        );

            base.OnModelCreating(modelBuilder);       
        }

    }
}