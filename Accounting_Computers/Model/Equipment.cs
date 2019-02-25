using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Computers.Model
{
    enum TypeEquipmen { printer, monitor}

    public struct Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public TypeEquipmen typeEquipment T{ get; set; }

    }
}
