
using System.ComponentModel.DataAnnotations;

namespace OptionsValidationSample.Configuration
{
    public class CustomConfig
    {
        [Required]
        public string Setting1 { get; set; }
        public string Setting2 { get; set; }
        public string Setting3 { get; set; }
    }
}
