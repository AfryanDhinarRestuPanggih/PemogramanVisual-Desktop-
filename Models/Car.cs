using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GarasiMobil.Models
{
    [BsonIgnoreExtraElements] // Amanin kalau ada field tambahan di MongoDB
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Merk")]
        public string Merk { get; set; } = null!;

        [BsonElement("Model")]
        public string Model { get; set; } = null!;

        [BsonElement("Tahun")]
        public int Tahun { get; set; }

        [BsonElement("Harga")]
        public decimal Harga { get; set; }

        [BsonElement("Warna")]
        public string Warna { get; set; } = null!;

        [BsonElement("GambarUrl")]
        public string? GambarUrl { get; set; }
    }
}
