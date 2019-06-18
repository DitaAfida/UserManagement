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
    [Table("TB_M_Province")]
    public class Province : BaseModel
    {
        public string Province_Name { get; set; }

        public Province() { }

        public Province(ProvinceVM provinceVM)
        {
            this.Province_Name = provinceVM.Province_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(ProvinceVM provinceVM)
        {
            this.Id = provinceVM.Id;
            this.Province_Name = provinceVM.Province_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
