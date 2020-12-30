using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {
        }

        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }


        //associação de muitos para muitos - classe intermediária

        public int AlunoId { get; set; }

        public int DisciplinaId { get; set; }

        //retorna o objeto todo
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}
