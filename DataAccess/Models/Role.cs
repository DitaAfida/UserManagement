﻿using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Role")]
    public class Role : BaseModel
    {
        public int Role_Name { get; set; }
    }
}
