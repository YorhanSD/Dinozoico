using Dinozoico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinozoico.Repositorio
{
    public interface IDinossauroRepositorio
    {
        List<DinossauroModel> BuscarTodos();
        DinossauroModel Adicionar(DinossauroModel dinossauro);
    }
}
