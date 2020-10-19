using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AspNetMongoDB.Models
{
    public class Roupa : Produto
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        public string Descricao { get; set; }

    }
}