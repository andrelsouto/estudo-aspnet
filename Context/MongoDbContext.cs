using System;
using MongoDB.Driver;
using rest_consulta.Model;

namespace rest_consulta.Context
{
    public class MongoDbContext
    {
        
        public static string ConnectionString = "mongodb://root:root@localhost:27017/";
        public static string DatabaseName = "plano";
        private IMongoDatabase _database{ get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            } catch (Exception e)
            {
                throw new Exception("Erro ao se conectar com o servidor", e);
            }
        }

        public IMongoCollection<Plano> Planos
        {
            get
            {
                return _database.GetCollection<Plano>("Planos");
            }
        }

    }
}