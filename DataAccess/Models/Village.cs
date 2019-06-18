using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Village")]
    public class Village : BaseModel
    {
        public string Village_Name { get; set; }
        
        [ForeignKey("District")]
        public int District_Id { get; set; }
        public District District { get; set; }
    }
}
