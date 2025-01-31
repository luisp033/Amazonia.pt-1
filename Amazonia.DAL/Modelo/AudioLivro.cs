using System.ComponentModel.DataAnnotations;

namespace Amazonia.DAL.Modelo
{
    public class AudioLivro : Livro
    {
        [Required]
        [MinLength(3)]
        [MaxLength(5)]
        public string FormatoFicheiro { get; set; }  //PDF, DOC, EPUB ....

        [Range(1,6000)]
        public int? DuracaoLivroEmMinutos { get; set; }

        public override string ToString()
        {
            return  $"{base.ToString()} Formato Ficheiro: {FormatoFicheiro} => Duracao: {DuracaoLivroEmMinutos} ";
        }
    }
}
