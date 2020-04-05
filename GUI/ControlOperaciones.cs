

using System;
using System.Windows.Forms;

namespace N3_Ahorcado.GUI
{

    public partial class ControlOperaciones : UserControl
    {
        #region Campos
        /// <summary>
        /// Referencia al formulario principal del juego.
        /// </summary>
        private Principal m_principal;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia de la clase ControlOperaciones.
        /// </summary>
        /// <param name="principal">Referencia al formulario principal.</param>
        public ControlOperaciones(Principal principal)
        {
            InitializeComponent();

            m_principal = principal;
        }
        #endregion

        #region Eventos

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            m_principal.IniciarJuego();
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            m_principal.PuntoExtension1();
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            m_principal.PuntoExtension2();
        }
        #endregion
    }
}
