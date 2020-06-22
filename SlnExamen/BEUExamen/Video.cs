//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUExamen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Video
    {
        [ScaffoldColumn(false)]
        public int idvideo { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El titulo es requerido"), MaxLength(55)]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }
        [Display(Name = "Fecha publicacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> fecha_publicacion { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El formato es requerido"), MaxLength(55)]
        [Display(Name = "Formato")]
        public string formato { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La duracion es requerida"), MaxLength(55)]
        [Display(Name = "Duracion")]
        public string duracion { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "La categoria es requerido"), MaxLength(55)]
        [Display(Name = "Categoria")]
        public string categoria { get; set; }
    }
}
