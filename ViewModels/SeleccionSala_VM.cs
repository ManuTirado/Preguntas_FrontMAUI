using Modelos;
using Models.Utilidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontMaui.ViewModels
{
    public class SeleccionSala_VM:clsVMBase
    {
        #region Atributos
        private ObservableCollection<clsSala> listaSalas;
        private clsSala salaSeleccionada;
        private string nombreUsuario;
        private DelegateCommand unirseASala;
        #endregion

        #region Propiedades
        public ObservableCollection<clsSala> ListaSalas
        {
            get
            {
                return listaSalas;
            }
            set
            {
                listaSalas = value;
            }
        }

        public clsSala SalaSeleccionada { get { return salaSeleccionada; } set { salaSeleccionada = value; } }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }
            set
            {
                nombreUsuario = value;
            }
        }

        public DelegateCommand UnirseASala
        {
            get
            {
                return unirseASala;
            }
        }
        #endregion

        #region Constructores
        public SeleccionSala_VM()
        {
            listaSalas=new ObservableCollection<clsSala>();
            listaSalas.Add(new clsSala("Sala1", 1, new clsUsuario[] {new clsUsuario("idConexion", "Kaki", 0, false), new clsUsuario("idConexion", "Fresco", 0, false) }, 1));
            listaSalas.Add(new clsSala("Sala2", 2, new clsUsuario[] {new clsUsuario("idConexion", "Colombi", 0, false) }, 1));
            listaSalas.Add(new clsSala("Sala3", 3, new clsUsuario[] {new clsUsuario("idConexion", "Deivi", 0, false) }, 1));
            listaSalas.Add(new clsSala("Sala4", 4, new clsUsuario[] {new clsUsuario("idConexion", "lolo", 0, false) }, 1));
            listaSalas.Add(new clsSala("Sala5", 5, new clsUsuario[] { }, 1));
            NotifyPropertyChanged(nameof(ListaSalas));
        }
        #endregion

        #region Comandos
        #endregion
    }
}
