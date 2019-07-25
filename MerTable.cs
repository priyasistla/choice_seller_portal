using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoiceProject.Models
{
    public class MerTable
    {
        private MongoClient mongoClient;


        public bool success;
        public string message;
        public List<List<string>> num;
        public MerTable(string pname)
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("db1");
            var collection1 = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();

            var collection = database.GetCollection<BsonDocument>("Product");
            /*List<BsonDocument> items = new List<BsonDocument>();
            var filter = Builders<BsonDocument>.Filter.Eq("P_Name", pname);
            items = collection.Find(filter).ToList();*/
            List<BsonDocument> items = collection1.Find(new BsonDocument()).ToList();


            //items = collection.Find(filter1).ToList();
            //List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();
            this.success = false;
            try
            {

                this.num = new List<List<string>>();


                foreach (var y in items)
                {
                    foreach (var x in items1)
                    {
                        List<string> l = new List<string> { };
                        if (x["_id"] == y[6])
                        {
                            l.Add(x["M_Name"].ToString());
                            l.Add(y["P_Price"].ToString());
                            l.Count();
                            this.num.Add(l);
                        }
                    }
                }
                this.success = true;
                this.message = "success";
            }
            catch (Exception e)
            {
                this.message = e.Message;
            }


        }

    }
}