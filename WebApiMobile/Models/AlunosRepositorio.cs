using System;
using System.Linq;

namespace WebApiMobile.Models
{
    public class AlunosRepositorio : IAlunoRepositorio
    {
        public AlunosRepositorio()
        {
            
        }

        public Alunos Login(string email, string senha)
        {
            try
            {
                using (var dbContext = new DbContextAluno()) //Criar uma instância do banco e desconeta ao final do using
                {
                    //retorna o objeto aluno com os dados caso encontre por email e senha, senão retorna null
                    return dbContext.Alunos.Where(p => p.EMAIL == email && p.SENHA == senha).FirstOrDefault();                    
                }                
            }
            catch (Exception e)
            {
                //lança a exceção interna para a controladora tratar
                throw e;
            }            
        }
    }
}