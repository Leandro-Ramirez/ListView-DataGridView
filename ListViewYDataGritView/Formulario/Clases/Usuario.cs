#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Formulario.Clases
{
    class Usuario
    {
        #region Variables Globales
        private string TipoUsuario;
        private string Codigo;
        private string Nombre;
        private string Carnet;
        private string Carrera;
        private string Genero;
        private string Celular;
        private string Correo;
        #endregion

        #region Public Objeto Usuario
        public Usuario(string tipoUsuario, string codigo,
            string nombre, string carnet,
            string carrera, string genero,
            string celular, string correo)
        {
            TipoUsuarios = tipoUsuario;
            Codigos = codigo;
            Nombres = nombre;
            Carnets = carnet;
            Carreras = carrera;
            Generos = genero;
            Celulares = celular;
            Correos = correo;
        }
        #endregion



        #region Get & Set
        public string TipoUsuarios
        {
            get => TipoUsuario;
            set => TipoUsuario = value;
        }
        public string Codigos
        {
            get => Codigo;
            set => Codigo = value;
        }
        public string Nombres
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string Carnets
        {
            get => Carnet;
            set => Carnet = value;
        }
        public string Carreras
        {
            get => Carrera;
            set => Carrera = value;
        }
        public string Generos
        {
            get => Genero;
            set => Genero = value;
        }
        public string Celulares
        {
            get => Celular;
            set => Celular = value;
        }
        public string Correos
        {
            get => Correo;
            set => Correo = value;
        }
        #endregion
    }
}