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

        public Color TurnoAsignado()
        {
            return Color.FromArgb(16, 196, 192);
        }

        public Color RestaurarColorTurnoAsignado()
        {
            return Color.FromArgb(180, 250, 243);
        }

        public Color TurnoEnCurso()
        {
            return Color.FromArgb(11, 133, 16);
        }

        public Color RestaurarColorTurnoEnCurso()
        {
            return Color.FromArgb(192, 255, 192);
        }
    }
}
