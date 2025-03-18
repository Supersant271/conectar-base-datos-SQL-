using.MongoDb.Bson.serialization.Attributes;

public class SalonMongo {
    [BsonId]
    [BsonRepresentation(MongoDb.Bson.BsonType.ObjecId)]
    public string? Id { get; set; }
    public string Edificio { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Uso { get; set; } = string.Empty;
    public decimal largo { get; set; }
    public decimal anchoo { get; set; }
    public int capacidad { get; set; }
    public List<String>? Grupos { get; set; }
}
