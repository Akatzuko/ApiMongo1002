using System.Linq;
using ApiProyecto1002.Models;
using MongoDB.Driver;

namespace ApiProyecto1002.Services
{
    public class EscuelaService
    {
        private IMongoCollection<Alumnos> _alumnos;
        public EscuelaService(IEscuelaSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _alumnos = database.GetCollection<Alumnos>(settings.Collection);
        }
        public List<Alumnos> Get()
        {
            return _alumnos.Find(d => true).ToList();
        }
        public alumnos Create(Alumnos alumnos)
        {
            _alumnos.InsertOne(alumnos);
            return alumnos;
        }
        public void Update(string id, Alumnos alumnos)
        {
            _alumnos.ReplaceOne(alumnos => alumnos.Id == id, alumnos);
        }
        public void Delete(string id)
        {
            _alumnos.DeleteOne(d => id == id);
        }
    }
}
