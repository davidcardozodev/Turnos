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

        public Color Verde()
        {
            return Color.FromArgb(23, 176, 1);
        }

        public Color Naranja()
        {
            return Color.FromArgb(255, 163, 14);
        }

        public Color Rojo()
        {
            return Color.FromArgb(255, 0, 0);
        }

        public Color Azul()
        {
            return Color.FromArgb(0, 0, 255);
        }
    }
}
