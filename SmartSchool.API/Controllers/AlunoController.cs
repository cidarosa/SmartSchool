using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        public AlunoController()
        {

        }

        public List<Aluno> Alunos = new List<Aluno>()
        {
             new Aluno(){
                Id = 1,
                Nome="Marcos",
                Sobrenome="Silva",
                Telefone="123456"
            },
             new Aluno(){
                Id = 2,
                Nome="Vinícios",
                Sobrenome="Toscos",
                Telefone="6541237"
            },
             new Aluno(){
                Id = 3,
                Nome="Marta",
                Sobrenome="Almeida",
                Telefone="857414"
            }
        };

        // GET: api/<AlunoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return (IEnumerable<string>)Alunos;  //new string[] { "value1", "value2" };
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            return aluno.Nome;
        }

        // POST api/<AlunoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
