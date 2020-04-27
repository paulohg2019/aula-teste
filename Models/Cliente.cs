using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Nome:")]
        public string UserName { get; set; }

        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Display(Name = "Telefone:")]
        public int PhoneNumber { get; set; }

        [Display(Name = "CPF:")]
        public int CPF { get; set; }

        [Display(Name = "Data de nascimento:")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Display(Name = "Comentario sobre o cliente:")]
        public string Coment { get; set; }

    }
}
