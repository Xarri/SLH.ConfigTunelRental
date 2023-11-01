using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfgTunelRental
{
    /// <summary>
    /// Clase de atributos para la seccion CONFIGURACION.
    /// </summary>
    /// Autor: Pablo Glez.
    /// Fecha: 06/09/2023
    class SeccionConfiguracion
    {
        /// <summary>
        /// Nombre de la sección.
        /// </summary>
        private const string NOMBRE_SECCION = "CONFIGURACION";

        /// <summary>
        /// Código de la máquina
        /// </summary>
        public string codigoMaquina = "";

        /// <summary>
        /// Idioma
        /// </summary>
        public string idioma = "es-ES";

        /// <summary>
        /// Nivel log programa
        /// </summary>
        public int nivelLog = 3;

        #region DEFINICIONES RFID
        /// <summary>
        /// IP del lector RFID.
        /// </summary>
        public string lectorRFID = "";

        /// <summary>
        /// Potencia del lector RFID (11 - 31).
        /// </summary>
        public int potenciaRFID = 25;
        #endregion

        #region TIEMPOS
        
        #endregion


        /// <summary>
        /// Puerto COM
        /// </summary>
        public string puertoCOM = "COM5";
    }
}
