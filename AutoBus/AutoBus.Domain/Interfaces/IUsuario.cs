using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IUsuario
    {
        Task Save(Usuario departament);
        Task Save(List<Usuario> departaments);

        Task Update(Usuario departament);

        Task Update(List<Usuario> departaments);

        Task Get(int ID);

        Task<List<Usuario>> Getall();
    }
}
