using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
	public class RegistroJogoService : IRegistroJogoService
	{
		private readonly IRegistroJogoRepository _registroJogoRepository;
		private readonly IMapper _mapper;

		public RegistroJogoService(IRegistroJogoRepository registroJogoRepository, IMapper mapper)
		{
			_registroJogoRepository = registroJogoRepository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<RegistroJogoViewModel>> ObterTodosOsJogos()
		{
			return _mapper.Map<IEnumerable<RegistroJogoViewModel>>(await _registroJogoRepository.ObterTodosOsJogos());

		}

        public async Task RegistrarJogo(RegistroJogoViewModel registroJogoViewModel)
        {
            if (registroJogoViewModel.primeiroNumero != registroJogoViewModel.segundoNumero && registroJogoViewModel.primeiroNumero != registroJogoViewModel.terceiroNumero
               && registroJogoViewModel.primeiroNumero != registroJogoViewModel.quartoNumero && registroJogoViewModel.primeiroNumero != registroJogoViewModel.quintoNumero
               && registroJogoViewModel.primeiroNumero != registroJogoViewModel.sextoNumero

               && registroJogoViewModel.segundoNumero != registroJogoViewModel.terceiroNumero && registroJogoViewModel.segundoNumero != registroJogoViewModel.quartoNumero
               && registroJogoViewModel.segundoNumero != registroJogoViewModel.quintoNumero && registroJogoViewModel.segundoNumero != registroJogoViewModel.sextoNumero

               && registroJogoViewModel.terceiroNumero != registroJogoViewModel.quartoNumero && registroJogoViewModel.terceiroNumero != registroJogoViewModel.quintoNumero
               && registroJogoViewModel.terceiroNumero != registroJogoViewModel.sextoNumero

               && registroJogoViewModel.quartoNumero != registroJogoViewModel.quintoNumero && registroJogoViewModel.terceiroNumero != registroJogoViewModel.sextoNumero

               && registroJogoViewModel.quintoNumero != registroJogoViewModel.sextoNumero)
            {

                await _registroJogoRepository.RegistrarJogo(_mapper.Map<RegistroJogo>(registroJogoViewModel));
            }
            else
            {
                throw new ArgumentException("Dados incorretos, existem números repetidos no jogo");
            }
        }
    }
}

