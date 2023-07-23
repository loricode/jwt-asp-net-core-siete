namespace WebApiAdministrador.UsuarioJwt
{
    public interface IManejoJwt
    {
        public string GenerarToken(string Email, string Fullname);

    }
}
