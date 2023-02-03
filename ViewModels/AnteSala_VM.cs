using Models.Utilidades;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontMaui.ViewModels
{
    public class AnteSala_VM
    {
        #region Atributos
        private clsSala sala;
        private bool mostrarMensajeEspera;
        private DelegateCommand responderPregunta;
        #endregion

        #region Propiedades
        public clsSala Sala
        {
            get
            {
                return sala;
            }
            set
            {
                sala = value;
            }
        }

        public bool MostrarMensajeEspera
        {
            get
            {
                return mostrarMensajeEspera;
            }
            set
            {
                mostrarMensajeEspera = value;
            }
        }

        public DelegateCommand ResponderPregunta
        {
            get
            {
                return responderPregunta;
            }
        }
        #endregion

        #region Constructores
        public AnteSala_VM()
        {

        }
        #endregion

        #region Comandos
        #endregion
    }
}
