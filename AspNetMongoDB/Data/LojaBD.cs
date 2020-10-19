using AspNetMongoDB.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;


namespace AspNetMongoDB.Data
{
    public class LojaBD
    {
        public MongoDatabase Database;
        public String DatabaseName = "LojaDB";
        
        string conexaoMongo = "";

        public LojaBD()
        {
            conexaoMongo = ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString;
            var client = new MongoClient(conexaoMongo);
            //Método abaixo é obsoleto, dps pesquisar novas alternativas
            var server = client.GetServer();

            Database = server.GetDatabase(DatabaseName);
        }

        public MongoCollection<Roupa> Roupas 
        {
            get {
                var Roupas = Database.GetCollection<Roupa>("Roupas");
                return Roupas;
                }
        }
    }
}