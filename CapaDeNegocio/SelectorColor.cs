using System.Drawing;

namespace CapaDeNegocio
{
    public class SelectorColor
    {
        public Color CambiarColor()
        {
            return Color.FromArgb(214, 248, 248);
        }

        public Color RestaurarColor()
        {
            return Color.FromArgb(255, 255, 255);
        }

        public Color PrioridadBaja()
        {
            return Color.FromArgb(23, 176, 1);
        }

        public Color PrioridadMedia()
        {
            return Color.FromArgb(255, 163, 14);
        }

        public Color PrioridadAlta()
        {
            return Color.FromArgb(255, 64, 14);
        }
    }
}
