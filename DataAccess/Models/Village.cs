using Core.Base;
using DataAccess.ViewModels;
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

        public Village() { }

        public Village(VillageVM villageVM)
        {
            this.Village_Name = villageVM.Village_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(VillageVM villageVM)
        {
            this.Id = villageVM.Id;
            this.Village_Name = villageVM.Village_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
