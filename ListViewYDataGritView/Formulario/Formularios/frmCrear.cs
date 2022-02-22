#region Usos
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
#endregion

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
                txtCorreo.Text == "" || cmbNumero.SelectedIndex.ToString() == "" ||
                cmbGenero.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Existen Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellidoP.Text == "" ||
                txtApellidoM.Text == "" || txtNumero.Text == "" || txtCelular.Text == "" ||
                txtCorreo.Text == "" || cmbNumero.SelectedIndex.ToString() == "LGBTQ" ||
                cmbGenero.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("No te puedes reproducir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellidoP.Text == "" ||
                txtApellidoM.Text == "" || txtNumero.Text == "" || txtCelular.Text == "" ||
                txtCorreo.Text == "" || cmbNumero.SelectedIndex.ToString() == "LGBTQ" || 
                cmbGenero.SelectedIndex.ToString() == "HelicopteroApacheDeCombate")
            {
                MessageBox.Show("A compadre, eres un Helicoptero de combate, SHEEEEEEESH", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GuardarUsuario();
                MessageBox.Show("");
            }
        }

        private void GuardarUsuario()
        {
            GuardarUsuarios();
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ListaUsuario;
        }
        #endregion

        #region Boton salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Cargar Form
        private void FrmCrear_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ListaUsuario;
        }
        #endregion

        #region GuardarUsuarios
        public void GuardarUsuarios()
        {
            Usuario user = new Usuario(cmbTipo.SelectedItem.ToString(), txtCodigo.Text, 
                txtNombre.Text + " " + txtApellidoP.Text + " " + txtApellidoM.Text,
                txtNumero.Text + " " + cmbNumero.SelectedItem.ToString(),
                cmbCarrera.SelectedItem.ToString(), cmbGenero.SelectedItem.ToString(),
                txtCelular.Text, txtCorreo.Text);

            ListaUsuario.Add(user);

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ListaUsuario;

            cmbTipo.SelectedIndex = -1;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtNumero.Clear();
            cmbNumero.SelectedIndex = -1;
            cmbCarrera.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            txtCelular.Clear();
            txtCorreo.Clear();
        }

        #endregion
    }
}