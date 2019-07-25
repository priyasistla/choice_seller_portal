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
    public class Merchant
    {
        [BsonId]
        public ObjectId Id
        {
            get;
            set;
        }

        [BsonElement("M_Name")]
        public string M_Name
        {
            get;
            set;
        }
        [BsonElement("M_Phone")]
        public int M_Phone
        {
            get;
            set;
        }

        [BsonElement("M_Tin")]

        public int M_Tin
        {
            get;
            set;
        }

        [BsonElement("M_email")]

        public string M_email
        {
            get;
            set;
        }
        [BsonElement("Mshop_Address")]

        public string Mshop_Address
        {
            get;
            set;
        }
        [BsonElement("Password")]

        public string Password
        {
            get;
            set;
        }
        [BsonElement("Re_Password")]

        public string Re_Password
        {
            get;
            set;
        }

    }
}