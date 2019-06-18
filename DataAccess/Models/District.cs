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
    [Table("TB_M_District")]
    public class District : BaseModel
    {
        public string District_Name { get; set; }

        [ForeignKey("Regency")]
        public int Regency_Id { get; set; }
        public Regency Regency { get; set; }

        public District() { }

        public District(DistrictVM districtVM)
        {
            this.District_Name = districtVM.District_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(DistrictVM districtVM)
        {
            this.Id = districtVM.Id;
            this.District_Name = districtVM.District_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
