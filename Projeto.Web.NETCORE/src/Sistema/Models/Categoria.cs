using System;
using System.ComponentModel.DataAnnotations;


namespace Sistema.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required(ErrorMessage ="Campo Requerido")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="O nome deve ter entre 3 a 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(256,ErrorMessage ="A descrição não deve exceder 256 caracteres")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        public Boolean Estado { get; set; }
    }
}
