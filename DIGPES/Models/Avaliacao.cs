using System;
using System.ComponentModel.DataAnnotations;
using DIGPES.Models.Enum;

namespace DIGPES.Models
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoID { get; set; }

        [Required]
        [Display(Name = "OS")]
        public int OrdemServico { get; set; }

        [Required]
        [StringLength(20)]
        public string Produto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe uma data válida.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Questão A")]
        public EnumRespostas QuestaoA { get; set; }

        [StringLength(30)]
        [Display(Name = "Questão B")]
        public string QuestaoB { get; set; }

        [StringLength(30)]
        [Display(Name = "Questão C")]
        public string QuestaoC { get; set; }

        [StringLength(30)]
        [Display(Name = "Questão D")]
        public string QuestaoD { get; set; }

        [StringLength(255)]
        [Display(Name = "Motivo Questão D")]
        public string MotivoQuestaoD { get; set; }

        [Required]
        [Display(Name = "Questão E")]
        public EnumRespostas QuestaoE { get; set; }

    }
}