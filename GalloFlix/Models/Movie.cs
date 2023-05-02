using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Movie")]
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Display(Name = "Titulo")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = " O Título deve possuir no maximo 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Titulo Original")]
    [Required(ErrorMessage = "O Título Original é obrigatório")]
    [StringLength(100, ErrorMessage = " O Título Original deve possuir no maximo 100 caracteres")]
    public string TitleOriginal { get; set; }

    [Display(Name = "Sinopse")]
    [Required(ErrorMessage = "O Sinopse é obrigatório")]
    [StringLength(100, ErrorMessage = " A Sinopse deve possuir no maximo 100 caracteres")]
    public string Synopsis { get; set; }

    [Column(TypeName = "Year")]
    [Display(Name = "Ano de Estreia")]
    [Required(ErrorMessage = "O Ano de Estreia é obrigatório")]
    public Int16 MovieYear { get; set; }

    [Display(Name = "Duração (em minitos")]
    [Required(ErrorMessage = "A duração é obrigatória")]
    public Int16 Duration { get; set; }

    [Display(Name = "Classificação Etária")]
    [Required(ErrorMessage = "A Classificação Etária é obrigatória")]
    public byte AgeRating { get; set; }

    [StringLength(200)]
    [Display(Name = "Foto")]
    public string Image {get; set; }

    [NotMapped]
    [Display(Name = "Duração")]
    public string HourDuration { get{ 
        return TimeSpan.FromMinutes(Duration).ToString(@"%h'h'mn'min'");
    }}

    public ICollection<MovieComment> Comments { get; set; }
     public ICollection<MovieGenre> Genres { get; set; }
     public ICollection<MovieRating> Ratings { get; set; }
}
