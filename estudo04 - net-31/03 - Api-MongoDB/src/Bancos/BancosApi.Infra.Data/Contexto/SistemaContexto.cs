using BancosAPI.Dominio.Entidades;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BancosAPI.Infra.Data.Contexto
{
    public class SistemaContexto : ISistemaContexto
    {
        public IMongoCollection<BancoEntidade> Bancos { get; }

        public SistemaContexto(IConfiguration configuration) 
        {
            
            var connectionString = configuration.GetSection("DatabaseSettings:ConnectionString").Value;
            var databaseName = configuration.GetSection("DatabaseSettings:DatabaseName").Value;
            var collectionName = configuration.GetSection("DatabaseSettings:CollectionName").Value;
            
            //MongoClient: estabelecer a conexão com o servidor MongoDB, através da string de coenxão.
            var client = new MongoClient(connectionString);
            
            //MongoClient.GetDatabase: obter o banco de dados no MongoDB.
            var database = client.GetDatabase(databaseName);

            //IMongoDatabase.GetCollection<T>: obter a coleção de dados do tipo T
            Bancos = database.GetCollection<BancoEntidade>(collectionName);
            
            //CatalogContextSeed.SeedData(Bancos);// alimentar coleção
        }

        //Definir entidades 
        //****************************************************************************
        


        

    }
}

