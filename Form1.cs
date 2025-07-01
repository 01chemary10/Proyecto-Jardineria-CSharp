/*
NOMBRE: JOSE MARÍA MOLINA SÁNCHEZ. 
DNI: 29061256C.
CURSO: PROGRAMACIÓN EN LENGUAJES ESTRUCTURADOS DE APLICACIONES DE GESTIÓN.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E1_UF2180___Practica_evaluable
{
    // Menú principal
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón para añadir nuevos clientes
        private void btnAnadirNuevoCliente_Click_1(object sender, EventArgs e)
        {
            FormAltaCliente formularioAlta = new FormAltaCliente();
            formularioAlta.Show();
        }

        // Botón para consultar clientes
        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FormConsultarCliente formConsulta = new FormConsultarCliente();
            formConsulta.Show();
        }

        // Botón para consultar clientes por empleado
        private void btnConsultarPorEmpleado_Click(object sender, EventArgs e)
        {
            FormClientesPorEmpleado form = new FormClientesPorEmpleado();
            form.Show();
        }

        // Botón para salir del menú principal

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
