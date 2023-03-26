using Controle_de_cadastros.Models;
using Controle_de_cadastros.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_cadastros.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio) 
        { 
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
           List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();

            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
          ContatoModel contato = _contatoRepositorio.ListarPorId(id);
          return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                
                {
                   bool apagado = _contatoRepositorio.Apagar(id);

                    if (apagado)
                    {
                        TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Ops, nao conseguimos apagar seu o contato";
                    }
                    
                    return RedirectToAction("Index");
                }
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos apagar o contato, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
            
           
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {   
           try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception erro) 
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos cadastrar o contato, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        } 
        
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, nao conseguimos atualizar o contato, tente novamente, detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
