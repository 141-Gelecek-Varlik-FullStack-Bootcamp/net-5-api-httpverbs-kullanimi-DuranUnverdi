using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Display(Name = "UserPassword")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

    }
}
