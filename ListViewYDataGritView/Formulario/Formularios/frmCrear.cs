using Formulario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Formularios
{
    public partial class frmCrear : Form
    {
        #region Variables Globales
        static List<Usuario> ListaUsuario = new List<Usuario>();
        List<string> ListTipoUsuario = new List<string>();
        #endregion

        #region Inicializar Componente frmCrear
        public frmCrear()
        {
            InitializeComponent();
            ListTipoUsuario.Add("Administrador");
            ListTipoUsuario.Add("Profesor");
            ListTipoUsuario.Add("Estudiante");

            foreach (string elemento in ListTipoUsuario)
            {
                cmbTipo.Items.Add(elemento);
            }
        }
        #endregion

        #region Boton Crear Click
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellidoP.Text == "" ||
                txtApellidoM.Text == "" || txtNumero.Text == "" || txtCelular.Text == "" ||
                txtCorreo.Text == "")
            {
                MessageBox.Show("Existen Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GuardarUsuario();
                MessageBox.Show("");
            }
        }

        private void GuardarUsuario()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ListaUsuario;
        }
        #endregion
    }
}