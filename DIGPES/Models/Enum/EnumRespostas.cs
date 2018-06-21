using System;
using System.ComponentModel.DataAnnotations;

namespace DIGPES.Models.Enum
{
    public enum EnumRespostas : byte
    {

        [Display(Name = "Não")]
        Nao,
        [Display(Name = "Sim")]
        Sim
    }

    [Flags]
    public enum FlagsEnum : byte
    {
        Nao = 0,
        Sim = 1
    }
}