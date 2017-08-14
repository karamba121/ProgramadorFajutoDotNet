﻿using ProgramadorFajuto.Domain.Dominio.Entidades;
using ProgramadorFajuto.Domain.Dominio.Repositorios;
using ProgramadorFajuto.Infraestructure.Infra.Servicos.EF.Repositorios.Base;

namespace ProgramadorFajuto.Infraestructure.Infra.Servicos.EF.Repositorios
{
    public class RepositorioDeUsuarios : RepositorioEF<Usuario>, IRepositorioDeUsuarios
    {
        public RepositorioDeUsuarios(ContextoEF contexto) : base(contexto) { }
    }
}
