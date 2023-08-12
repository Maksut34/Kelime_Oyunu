using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel_Entity.Model
{
	public class Öneriler
	{
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(15)]
        public string Soru { get; set; }
		[Required]
		[MinLength(2)]
		public string cevap { get; set; }
    }
}
