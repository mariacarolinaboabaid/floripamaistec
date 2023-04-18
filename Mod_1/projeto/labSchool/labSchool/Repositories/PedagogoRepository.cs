using System;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories.Interfaces;

namespace labSchool.Repositories
{
    public class PedagogoRepository : IPedagogoRepository
    {
        // INJEÇÃO DE DEPENDÊNCIA DO BD
        private readonly LabSchoolContext _context;

        public PedagogoRepository(LabSchoolContext context)
        {
            _context = context;
        }

        // OBTER LISTA COMPLETA DE PROFESSORES
        public List<Pedagogo> Obter()
        {
            return _context.Pedagogos.ToList();
        }

    }
}

