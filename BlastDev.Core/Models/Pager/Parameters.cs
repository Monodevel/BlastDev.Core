using BlastDev.Core.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace BlastDev.Core.Models.Pager
{
    public class Parameters:IDtoBase
    {
        [Range(1,int.MaxValue, ErrorMessage = "The {0} field not is valid.")]
        public int CurrentPage {  get; set; }

        [Range(1,int.MaxValue, ErrorMessage ="The {0} field not is valid.")]
        public int PageSize { get; set; }

        [Range(0,int.MaxValue, ErrorMessage ="The {0} field not is valid.")]
        public int MaxPage { get; set; }
    }
}
