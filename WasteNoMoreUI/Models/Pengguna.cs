using System;

namespace WasteNoMoreUI.Models
{
    public class Pengguna
    {
        public int IdPengguna { get; set; }
        public string NamaPengguna { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Pengguna(int idPengguna, string namaPengguna, string email, string username, string password)
        {
            IdPengguna = idPengguna;
            NamaPengguna = namaPengguna;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}