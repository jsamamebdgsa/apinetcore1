using Data.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositorios
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
        Categoria GetDetail(int id);
    }
}
