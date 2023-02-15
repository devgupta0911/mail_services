using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor.Core.Domain.Models
{
    public class AdvisorClientTable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int AdvisorID { get; set; }

        [Required]
        [ForeignKey("Users")]

        public int ClientID { get; set; }
        
    }
}
