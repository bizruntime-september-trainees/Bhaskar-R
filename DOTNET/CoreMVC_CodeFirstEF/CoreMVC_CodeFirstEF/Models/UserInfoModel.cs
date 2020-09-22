using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC_CodeFirstEF.Models
{
    public class UserInfoModel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
