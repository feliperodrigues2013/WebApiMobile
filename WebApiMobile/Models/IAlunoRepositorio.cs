
namespace WebApiMobile.Models
{
    interface IAlunoRepositorio //interface aluno
    {
        Alunos Login(string email, string senha);
    }
}
