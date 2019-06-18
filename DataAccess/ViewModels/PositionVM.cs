using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class PositionVM
    {
        public int Id { get; set; }
        public string Position_Name { get; set; }

        public PositionVM() { }

        public PositionVM(string position_name)
        {
            this.Position_Name = position_name;
        }

        public void Update(int id, string position_name)
        {
            this.Id = id;
            this.Position_Name = position_name;
        }
    }
}
