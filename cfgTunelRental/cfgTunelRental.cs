using System;

namespace cfgTunelRental
{
    public class cfgTunelRental
    {
        /// <summary>
        /// Ruta completa y nombre del archivo INI
        /// </summary>
        private readonly string pathArchivoINI = $"{System.Reflection.Assembly.GetExecutingAssembly().Location}\\Configuracion\\Config.ini";

        /// <summary>
        /// Objeto para manejar el archivo ini
        /// </summary>
        private SicoClases.Ficheros.clsINIs archivoINI;

        #region CONFIGURACIONES DE LA SECCION [CONFIGURACION]

        #endregion

        /*
                //==== EQUIPO LECTOR ===================================================================================================            
                //POTENCIA
                Selecciona_SicoCombo(cboPotenciaLectura, Program.DefinicionesApp.RFID_Potencia.ToString(), SicontrolesWindowsNET.eTipoBusquedaValor.Texto);

                alfCodigoLector.Text = Program.DefinicionesApp.RFID_Maquina;
                    alfLectorRFID.Text = Program.DefinicionesApp.RFID_LectorRFID;
                    Selecciona_SicoCombo(cboCOM, Program.DefinicionesApp.CONFIG_PuertoCom, SicontrolesWindowsNET.eTipoBusquedaValor.Texto);
                cboIdioma.Items.Clear();
                    cboIdioma.Items.Add(new SicontrolesWindowsNET.General.clsComboBoxItem("es-ES", "es-ES"));
                    Selecciona_SicoCombo(cboIdioma, Program.DefinicionesApp.CONFIG_Idioma, SicontrolesWindowsNET.eTipoBusquedaValor.Texto);
                chkCarro.Checked = Program.DefinicionesApp.CONFIG_IdentificarCarro;
                    alfTiempoLectura.Text = Program.DefinicionesApp.RFID_TiempoLectura.ToString();
                    AlfElectronicaVer.Text = Program.DefinicionesApp.ELECTRONICA_VERSION.ToString();
                    Selecciona_SicoCombo(cboPuerta, Program.DefinicionesApp.ELECTRONICA_PUERTA.ToString(), SicontrolesWindowsNET.eTipoBusquedaValor.Texto);
                chkPuertaUnica.Checked = Program.DefinicionesApp.ELECTRONICA_PUERTA_UNICA;
                    //======================================================================================================================
        */
    }
}
