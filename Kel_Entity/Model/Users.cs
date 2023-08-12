using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel_Entity.Model
{
	public class Users
	{
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        public string name { get; set; }
        [Required]
        [MinLength(2)]
        public string surname { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string gsm { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
