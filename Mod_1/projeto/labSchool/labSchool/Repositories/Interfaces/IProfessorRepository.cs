using System;
using labSchool.Models;

namespace labSchool.Repositories.Interfaces
{
	public interface IProfessorRepository
	{
        // ASSINATURA
        public List<Professor> Obter();
    }
}

