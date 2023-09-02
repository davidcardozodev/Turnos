namespace CapaComun
{
    public class DatosUsuarioItem
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string TipoPlan { get; set; }
        public int HorarioInicio { get; set; }
        public int HorarioFin { get; set; }
    }
}
