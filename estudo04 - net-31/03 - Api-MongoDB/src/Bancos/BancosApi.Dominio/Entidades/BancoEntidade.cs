using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BancosAPI.Dominio.Entidades
{
    /// <summary>
    /// Classe de Dominio 
    /// </summary>
    public class BancoEntidade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string EmpresaID { get; set; }

    }
}
