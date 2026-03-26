using APIEstudoEFCore.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIEstudoEFCore.Entities;

namespace APIEstudoEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) { _context = context; }


        // criando endpoint criar post
        [HttpPost]
        public IActionResult CriarContato(Contato contato)
        {
            _context.Contatos.Add(contato);

            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id }, contato);
        }


        //Criando endpoint read / get obter por id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {

            var contato = _context.Contatos.Find(id);
            if (contato == null) return NotFound();

            return Ok(contato);

        }


        //criando obter contato por nome com get
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(String nome)
        {
            var contatos = _context.Contatos.Where(contato => contato.Nome.Contains(nome));
            if (contatos == null) return NotFound();

            return Ok(contatos);
        }



        //Criando endpoit de atualização update - put 
        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }


        //Criando endpoint de delete - delete 
        [HttpDelete("{id}")]
        public IActionResult DeletarContato(int id)
        {

            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null) return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();


            return NoContent();
        }

    }
}
