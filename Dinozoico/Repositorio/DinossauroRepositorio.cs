using Dinozoico.Data;
using Dinozoico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinozoico.Repositorio
{
    public class DinossauroRepositorio : IDinossauroRepositorio
    {
        private readonly BancoContext _bancoContext;
        public DinossauroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public DinossauroModel Adicionar(DinossauroModel dinossauro)
        {
            _bancoContext.Dinossauro.Add(dinossauro);
            _bancoContext.SaveChangesAsync();
            return dinossauro;
        }

        public List<DinossauroModel> BuscarTodos()
        {
            return _bancoContext.Dinossauro.ToList();
        }
    }
}
