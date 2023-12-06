using AutoMapper;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
    public class CollectionToDomain : Profile
    {
        public CollectionToDomain()
        {

            CreateMap<RegistroJogoCollection, RegistroJogo>()
               .ConstructUsing(r => new RegistroJogo(r.primeiroNumero, r.segundoNumero, r.terceiroNumero, r.quartoNumero, r.quintoNumero, r.sextoNumero));

        }
    }
}