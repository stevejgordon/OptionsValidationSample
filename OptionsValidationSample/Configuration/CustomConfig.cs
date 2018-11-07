
using System.ComponentModel.DataAnnotations;

namespace OptionsValidationSample.Configuration
{
    public class CustomConfig
    {
        [Required(ErrorMessage = "Custom Error Message")]
        public string Setting1 { get; set; }
        public string Setting2 { get; set; }
        public string Setting3 { get; set; }
    }
}
