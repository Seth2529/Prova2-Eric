using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
	public class RegistroJogoViewModel
    {
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int primeiroNumero { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int segundoNumero { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int terceiroNumero { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quartoNumero { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int quintoNumero { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [Range(1, 60)]
        public int sextoNumero { get; set; }
    }
}
