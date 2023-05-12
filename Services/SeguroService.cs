using ApiPolizas.Models;
using MongoDB.Driver;

namespace ApiPolizas.Services
{
    public class SeguroService
    {
        private IMongoCollection<Poliza> _polizas;

        public SeguroService(ISeguroSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _polizas = database.GetCollection<Poliza>(settings.Collection);
        }

        public List<Poliza> Get()
        {
            return _polizas.Find(d => true).ToList();
        }

        public List<Poliza> GetNumeroPoliza(int numPoliza)
        {
            return _polizas.Find(d => d.Num_poliza == numPoliza).ToList();
        }

        public Poliza Create(Poliza poliza)
        {
            _polizas.InsertOne(poliza);
                return poliza;
        }
    }
}
