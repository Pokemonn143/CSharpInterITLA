using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using AutoBus.Infraestructure.Exceptions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public UsuarioRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;
        }

        public override async Task Save(Usuario entity)
        {
            ArgumentNullException.ThrowIfNull(entity, "");

            if ((await base.Exists(cd => cd.IdUsuario == entity.IdUsuario))) { 

                throw new UsuarioDataException("");
            }

            base.Save(entity);

        }

        public List<UsuarioSelectModel> ObtenerUsuariosConNombresYApellidos()
        {
            var usuarios = _DbContext.Usuarios
           .Where(u => !string.IsNullOrEmpty(u.Nombres) && !string.IsNullOrEmpty(u.Apellidos))
           .ToList();

            var UsuarioModels = _mapper.Map<List<UsuarioSelectModel>>(usuarios);

            return UsuarioModels;
        }
    }
}
