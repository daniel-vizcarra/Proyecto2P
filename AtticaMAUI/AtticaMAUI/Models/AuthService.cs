using System.Collections.Generic;
using System.Linq;

namespace AtticaMAUI.Models
{
    public class AuthService
    {
        private static AuthService _instance;
        private List<User> _users;

        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthService();
                }
                return _instance;
            }
        }

        private AuthService()
        {
            _users = new List<User>();

            // Carga de usuarios de ejemplo
            _users.Add(new User { Username = "admin", Password = "admin123", Role = UserRole.Admin });
            _users.Add(new User { Username = "customer", Password = "customer123", Role = UserRole.Customer });
        }

        public bool Register(string username, string password, UserRole role)
        {
            if (_users.Any(u => u.Username == username))
                return false; // Usuario ya existe

            _users.Add(new User { Username = username, Password = password, Role = role });
            // Guardar usuarios en almacenamiento local si es necesario

            return true;
        }

        public UserRole GetRole(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user?.Role ?? UserRole.Customer; // Si no se encuentra, se devuelve el rol de Customer
        }

        // Otros métodos de gestión de usuarios: cambiar contraseña, eliminar usuario, etc.
    }
}
