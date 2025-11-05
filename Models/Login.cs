using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GarasiMobil.Models
{
    public class Login
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; } = null!;

        [BsonElement("Password")]
        public string Password { get; set; } = null!;
    }
}
