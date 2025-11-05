using GarasiMobil.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace GarasiMobil.Services
{
    public class LoginService
    {
        private readonly IMongoCollection<Login> _loginCollection;

        public LoginService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GarasiMobilDB");
            _loginCollection = database.GetCollection<Login>("Login");
        }

        // Validasi username dan password
        public Login? ValidateLogin(string username, string password)
        {
            return _loginCollection.Find(l => l.Username == username && l.Password == password).FirstOrDefault();
        }
    }
}
