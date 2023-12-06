using AutoMapper;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Data.Providers.MongoDb.Interfaces;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class RegistroJogoRepository : IRegistroJogoRepository
    {
        private readonly IMongoRepository<RegistroJogoCollection> _registroJogoRepository;
        private readonly IMapper _mapper;

        #region - Construtores

        public RegistroJogoRepository(IMongoRepository<RegistroJogoCollection> registroJogoRepository, IMapper mapper)
        {
            _registroJogoRepository = registroJogoRepository;
            _mapper = mapper;
        }

        #endregion
        public async Task<IEnumerable<RegistroJogo>> ObterTodosOsJogos()
        {
            var registrojogo = _registroJogoRepository.FilterBy(filter => true);

            return _mapper.Map<IEnumerable<RegistroJogo>>(registrojogo);
        }

        public async Task RegistrarJogo(RegistroJogo registroJogo)
        {
            await _registroJogoRepository.InsertOneAsync(_mapper.Map<RegistroJogoCollection>(registroJogo));
        }
    }
}
