using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ContactsLib.Models
{
    public partial class Contact
    {
        public int ContactNo { get; set; }
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Contact name should not contain numbers")]
        [Required]
        public string ContactName { get; set; }

        [Required]
        [ValidateCityName(ErrorMessage = "CityName is not available")]
        public string CityName { get; set; }
        [Required]

        [RegularExpression("^[0-9]*$", ErrorMessage = "Cell no must contain only numbers")]
        public long CellNo { get; set; }
    }
}
