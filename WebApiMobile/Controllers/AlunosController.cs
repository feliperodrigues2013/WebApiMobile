using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiMobile.Models;

namespace WebApiMobile.Controllers
{
    public class AlunosController : ApiController
    {
        static readonly IAlunoRepositorio repositorio = new AlunosRepositorio();//criando interface aluno

        public HttpResponseMessage GetAluno(string email, string senha)//solicitando o retorno do usuário e senha
        {
            try
            {
                //função para verificar o aluno no banco
                Alunos aluno = repositorio.Login(email,senha);
                if (aluno == null)
                {
                    //retorna 404 caso não encontre o aluno
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Aluno não encontrado");
                }
                //retorna 200 e o aluno caso encontre
                return Request.CreateResponse(HttpStatusCode.OK, aluno);
            }
            catch (Exception e)
            {
                //retorna 500 para erros internos
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
            
        }
    }
}