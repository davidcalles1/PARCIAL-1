using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PARCIAL1.DAO;
namespace PARCIAL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carga();
        }
        public void carga()
        {
            dtgTabla.Rows.Clear();
            using (EMPLEADOEntities db = new EMPLEADOEntities())

            {
                var lista = db.Tlb_Empleado.ToList();
                foreach (var iteracion in lista)
                {
                    dtgTabla.Rows.Add(iteracion.Id_empledo, iteracion.Empl_nombre, iteracion.Empl_apellido, iteracion.Empl_dui, iteracion.Empl_email, iteracion.Empl_tel,iteracion.Empl_direccion, iteracion.Empl_cargo);
                }
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
