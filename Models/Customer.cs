using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GarasiMobil.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nama")]
        public string Nama { get; set; } = null!;

        [BsonElement("Email")]
        public string Email { get; set; } = null!;

        [BsonElement("Telepon")]
        public string Telepon { get; set; } = null!;

        [BsonElement("Alamat")]
        public string Alamat { get; set; } = null!;

        [BsonElement("TanggalDaftar")]
        public DateTime TanggalDaftar { get; set; } = DateTime.Now;
    }
}
