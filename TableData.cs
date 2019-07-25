using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;


namespace ChoiceProject.Models
{
    public class TableData
    {
        private MongoClient mongoClient;


        public bool success;
        public string message;
        public List<List<string>> num;
        public TableData(string uat)
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("db1");
            
           /* var collection1 = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items1 = new List<BsonDocument>();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", uat) ;

            items1 = collection1.Find(filter).ToList();*/
            
            var collection = database.GetCollection<BsonDocument>("Product");
            //List<BsonDocument> items = collection.Find(new BsonDocument()).ToList();
            List<BsonDocument> items = new List<BsonDocument>();
            var filter1 = Builders<BsonDocument>.Filter.Eq("Merchant_id", uat);

            items = collection.Find(filter1).ToList();
            //List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();
            this.success = false;
            try
            {

                this.num = new List<List<string>>();


                foreach (var y in items)
                {
                    List<string> l = new List<string> { };
                    l.Add(y["_id"].ToString());
                    l.Add(y["P_Name"].ToString());
                    l.Add(y["Category"].ToString());
                    l.Add(y["Sub_category"].ToString());
                    l.Add(y["P_Price"].ToString());
                    l.Count();
                    this.num.Add(l);
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
 