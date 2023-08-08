using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentationLayer.GeneralScreens
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        #region "Mover ventana"
        private void MoverVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("Usuario32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("Usuario32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

    }
}
