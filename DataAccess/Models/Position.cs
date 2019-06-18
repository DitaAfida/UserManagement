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
    [Table("TB_M_Position")]
    public class Position : BaseModel
    {
        public string Position_Name { get; set; }

        public Position() { }

        public Position(PositionVM positionVM)
        {
            this.Position_Name = positionVM.Position_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update (PositionVM positionVM)
        {
            this.Id = positionVM.Id;
            this.Position_Name = positionVM.Position_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }

    
   
}
