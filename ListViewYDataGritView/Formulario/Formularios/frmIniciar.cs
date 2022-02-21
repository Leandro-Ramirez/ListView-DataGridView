#region Usos
using Formulario.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Formulario
{
    public partial class frmIniciar : Form
    {
        #region Variables Globales
        List<string> ListTipoUsuario = new List<string>();
        #endregion

        #region Iniciañizar Componente frmIniciar
        public frmIniciar()
        {
            InitializeComponent();
            ListTipoUsuario.Add("Administrador");
            ListTipoUsuario.Add("Profesor");
            ListTipoUsuario.Add("Estudiante");

            foreach (string elemento in ListTipoUsuario)
            {
                cmbTipo.Items.Add(elemento);
            }

            ttMensaje.SetToolTip(this.cmbTipo, "Ingrese el Rol que tiene");
            ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre del Usuario");
            ttMensaje.SetToolTip(this.txtContraseña, "Ingrese la Contraseña");
        }
        #endregion

        #region Cargar frmIniciar
        private void FrmIniciar_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }
        #endregion

        #region 
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Admin" && txtContraseña.Text == "1234" && cmbTipo.SelectedItem.ToString() == "Administrador")
            {
                this.Hide();
                frmCrear iuAdmin = new frmCrear();
                iuAdmin.lblTitulo2.Text = "Bienvenido" + "" + txtNombre.Text;
                iuAdmin.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
                txtContraseña.Clear();
            }
        }
        #endregion

        #region Boton Cerrar Click
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}