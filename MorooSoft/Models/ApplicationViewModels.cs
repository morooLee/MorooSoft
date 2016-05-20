using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MorooSoft.Models
{
    public class ApplicationViewModel
    {
        [Display(Name = "어플리케이션 이름")]
        public string AppName { get; set; }

        [Display(Name = "어플리케이션 버전")]
        public string AppVersion { get; set; }
    }
}
