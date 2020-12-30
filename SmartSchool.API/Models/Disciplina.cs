using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {
        }

        public Disciplina(int id, string nome, int professorId)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        //uma disciplina só pode ter um professor
        //ProfessorId => padrão do EF
        public int ProfessorId { get; set; }

        //para EF
        public Professor Professor { get; set; }

        // muitos para muitos
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}
