using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ThirdParty.Json.LitJson;

namespace ApiPolizas.Models
{
    public class Poliza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("num_poliza")]
        public int Num_poliza { get; set; }
        [BsonElement("nombre_cliente")]
        public string? Nombre_cliente { get; set; }
        [BsonElement("id_cliente")]
        public int Id_cliente { get; set; }
        [BsonElement("fecha_nacimiento_cliente")]
        public string? Fecha_nacimiento_cliente { get; set; }

        [BsonElement("fefecha_inicio_poliza")]
        public string? Fecha_inicio_poliza { get; set; }

        [BsonElement("cobertura_poliza")]
        public string? Cobertura_poliza { get; set; }
        [BsonElement("valor_maximo_poliza")]
        public int  Valor_maximo_poliza { get; set; }
        [BsonElement("nombre_poliza")]
        public string? Nombre_poliza { get; set; }
        [BsonElement("ciudad_cliente")]
        public string? Ciudad_cliente { get; set; }
        [BsonElement("direccion_cliente")]
        public string? Direccion_cliente { get; set; }
        [BsonElement("placa_automotor")]
        public string? Placa_automotor { get; set; }
        [BsonElement("modelo_automotor")]
        public string? Modelo_automotor { get; set; }
        [BsonElement("inspeccion_vehiculo")]
        public string? Inspeccion_vehiculo { get; set; }
        [BsonElement("fecha_fin_poliza")]
        public string? Fecha_fin_poliza { get; set; }

        [BsonElement("poliza_vigente")]
        public string? Poliza_vigente { get; set; }
    }
}
