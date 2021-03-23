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
            clear();
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
        void clear()
        {
            txtIDEmpleado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDui.Clear();
            txtEmail.Clear();
             
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCargo.Clear();
           
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dtgTabla.CurrentRow.Cells[0].Value.ToString();
            String nombre = dtgTabla.CurrentRow.Cells[1].Value.ToString();
            String apellido = dtgTabla.CurrentRow.Cells[2].Value.ToString();
            String dui = dtgTabla.CurrentRow.Cells[3].Value.ToString();
            
            String email = dtgTabla.CurrentRow.Cells[4].Value.ToString();
            String telefono = dtgTabla.CurrentRow.Cells[5].Value.ToString();
            String direccion = dtgTabla.CurrentRow.Cells[6].Value.ToString();
            String cargo = dtgTabla.CurrentRow.Cells[7].Value.ToString();
          
           
                
             txtIDEmpleado.Text= id;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDui.Text = dui;
             txtEmail.Text = email;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
            txtCargo.Text = cargo;
         

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                Tlb_Empleado r = new Tlb_Empleado();
                int eliminar = Convert.ToInt32(txtIDEmpleado.Text);
                r = db.Tlb_Empleado.Find(eliminar);
                db.Tlb_Empleado.Remove(r);
                db.SaveChanges();
                carga();
                clear();

            }


        }
    }
}
