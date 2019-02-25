using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Accounting_Computers.Model
{
   public struct ServiceEquipment
    {
        private delegate void dException(string message);
        public delegate void dSuccessfull(Equipment equipment);

        private dException DException;
        private dSuccessfull DSuccessfull;
        public void RegisterDelegate(dException DException)
        {
            this.DException = DException;
            this.DSuccessfull = DSuccessfull;

        }
        public void AddEquipment(Equipment equipment)
        {
            try
            {
                using (var db = new LiteDatabase("Accounting.db"))

                {
                    var equipments = db.GetCollection<Equipment>("Equipment");
                    equipments.Insert(equipment);


                }
                if (DSuccessfull != null)
                    DSuccessfull.Invoke(equipment);
    
            
            }
            catch(Exception ex)
            {
                if (DException != null)
                    DException.Invoke(ex.Message);
            }
        }
    }
}
