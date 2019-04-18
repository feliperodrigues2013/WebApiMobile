using System.Data.Entity;

namespace WebApiMobile.Models
{
    public class DbContextAluno : DbContext
    {
        //instânciando a classe para conectar na tabela
        public DbContextAluno() : base("name=DBASE")//nome do source da connection string
        {

        }
        public DbSet<Alunos> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);                  
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            Database.SetInitializer<DbContextAluno>(null);
            //Mapeando tabela de alunos para o entity           
            modelBuilder.Entity<Alunos>().HasKey(c => c.CPF).Property(c => c.CPF).HasColumnName("CPF");
            modelBuilder.Entity<Alunos>().Property(c => c.NOME).HasColumnName("NOME");
            modelBuilder.Entity<Alunos>().Property(c => c.ENDERECO).HasColumnName("ENDERECO");
            modelBuilder.Entity<Alunos>().Property(c => c.BAIRRO).HasColumnName("BAIRRO");
            modelBuilder.Entity<Alunos>().Property(c => c.MUNICIPIO).HasColumnName("MUNICIPIO");
            modelBuilder.Entity<Alunos>().Property(c => c.UF).HasColumnName("UF");
            modelBuilder.Entity<Alunos>().Property(c => c.TELEFONE).HasColumnName("TELEFONE");
            modelBuilder.Entity<Alunos>().Property(c => c.EMAIL).HasColumnName("EMAIL");
            modelBuilder.Entity<Alunos>().Property(c => c.SENHA).HasColumnName("SENHA");
            modelBuilder.Entity<Alunos>().ToTable("Alunos");
        }
    }
}