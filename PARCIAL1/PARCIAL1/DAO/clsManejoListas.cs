using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.DAO
{
    class clsManejoListas
    {

        public void delete(int ID) 
        {
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                Tlb_Empleado r = new Tlb_Empleado();
                int eliminar = Convert.ToInt32(ID);
                r = db.Tlb_Empleado.Find(eliminar);
                db.Tlb_Empleado.Remove(r);
                db.SaveChanges();
               

            }


        }

    }
}
