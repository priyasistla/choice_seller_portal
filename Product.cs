using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace ChoiceProject.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id
        {
            get;
            set;
        }
        [BsonElement("name")]
        public string Name
        {
            get;
            set;
        }
        [BsonElement("Price")]
        public int Price
        {
            get;
            set;
        }

        [BsonElement("Category")]

        public string Category
        {
            get;
            set;
        }

        [BsonElement("Physical_prop")]

        public string Physical_prop
        {
            get;
            set;
        }
        [BsonElement("Sub_category")]

        public string Sub_category
        {
            get;
            set;
        }
        [BsonId]
        public ObjectId Merchant_id
        {
            get;
            set;
        }

    }
}