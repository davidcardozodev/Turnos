namespace CapaDeNegocio
{
    public class Campo
    {

        private string _Mensaje = "";

        #region "Campos"

        public string VerificarCamposIndividuales(string Campo)
        {
            if (Campo == "Usuario")
                _Mensaje = "Ingrese su nombre de usuario";

            if (Campo == "Clave")
                _Mensaje = "Ingrese su clave";

            return _Mensaje;
        }

        public string VerficarTodosCampos(string CampoUsuario, string CampoClave)
        {
            if (CampoUsuario == "Usuario" && CampoClave == "Clave")
                _Mensaje = "Todos los campos deben estar llenos";

            return _Mensaje;
        }

        #endregion
    }
}
