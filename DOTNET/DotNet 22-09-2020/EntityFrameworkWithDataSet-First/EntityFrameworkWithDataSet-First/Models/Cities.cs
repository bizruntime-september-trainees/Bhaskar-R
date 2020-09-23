using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWithDataSet_First.Models
{
    public partial class Cities
    {
        [Key]
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
