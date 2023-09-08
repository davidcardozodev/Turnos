namespace CapaDeNegocio
{
    public class ComprobacionCampo
    {
        private string Mensaje = Campo.Vacio;

        public string VerificarCamposIndividuales(string campo)
        {
            if (campo == Campo.Usuario)
                Mensaje = Mensajes.ErrorUsuario;

            if (campo == Campo.Clave)
                Mensaje = Mensajes.ErrorClave;

            return Mensaje;
        }

        public string VerficarTodosCampos(string CampoUsuario, string CampoClave)
        {
            if (CampoUsuario == Campo.Usuario && CampoClave == Campo.Clave)
                Mensaje = Mensajes.ErrorCamposFaltantes;

            return Mensaje;
        }
    }
}
