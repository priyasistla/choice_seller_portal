using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;


namespace ChoiceProject.Models
{
    public class Category1
    {
        [BsonId]
        public ObjectId id
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
        [BsonElement("Sub_category")]
        public int Sub_category
        {
            get;
            set;
        }

        [BsonId]

        public ObjectId P_id
        {
            get;
            set;
        }

        [BsonId]

        public ObjectId M_id
        {
            get;
            set;
        }

    }
}