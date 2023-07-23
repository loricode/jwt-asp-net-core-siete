
namespace ModelosAdm.Usuario
{
    public class Usuario
    {
        public string UserId { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string Email { get; set; } = null!;

        public static List<Usuario> Login()
        {

            List<Usuario> result = new();

            var s = new Usuario { Email = "angel@gmail.com", UserId = "123", Fullname = "ajc" };
            var t = new Usuario { Email = "pipe@gmail.com", UserId = "1234", Fullname = "pipe" };
            var p = new Usuario { Email = "jose@gmail.com", UserId = "1235", Fullname = "jose" };

            result.Add(s);
            result.Add(t);
            result.Add(p);

            return result;
        }

    }
}
