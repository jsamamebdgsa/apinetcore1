using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Data.Entidades;

namespace Data.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository
    {
        IContext context;
        public CategoriaRepository(IContext _context)
        {
            context = _context;
        }

        public IEnumerable<Categoria> GetAll()
        {
            string sql = "SELECT * FROM Categoria";
            IEnumerable<Categoria> categorias = Enumerable.Empty<Categoria>();
            using (var connection = context.GetConnection())
            {
                categorias = connection.Query<Categoria>(sql).ToList();
            }
            return categorias;
        }

        public Categoria GetDetail(int id)
        {
            string sql = "SELECT * FROM Categoria WHERE Id = @categoryID;";
            Categoria categoria = null;
            using (var connection = context.GetConnection())
            {
                categoria = connection.QueryFirstOrDefault<Categoria>(sql, new { categoryID = id });                
            }
            return categoria;
        }
    }
}
