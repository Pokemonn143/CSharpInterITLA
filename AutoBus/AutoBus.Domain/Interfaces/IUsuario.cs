using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IUsuario
    {
        Task Save(Usuario usuario);
        Task Save(List<Usuario> usuarios);

        Task Update(Usuario usuario);

        Task Update(List<Usuario> usuarios);

        Task<Usuario> Get(int ID);

        Task<List<Usuario>> Getall();

        Task<bool> Exists(Expression<Func<Usuario, bool>> filter);
    }
}
