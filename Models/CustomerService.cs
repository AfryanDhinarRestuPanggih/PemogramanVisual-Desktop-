using MongoDB.Driver;
using GarasiMobil.Models;
using System.Collections.Generic;

namespace GarasiMobil.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GarasiMobilDB");
            _customers = database.GetCollection<Customer>("Customers");
        }

        public List<Customer> Get() => _customers.Find(c => true).ToList();

        public Customer Get(string id) => _customers.Find(c => c.Id == id).FirstOrDefault();

        public Customer Create(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public void Update(string id, Customer customer) =>
            _customers.ReplaceOne(c => c.Id == id, customer);

        public void Delete(string id) =>
            _customers.DeleteOne(c => c.Id == id);
    }
}
