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
    public class CategoryDOA
    {
        private MongoClient mongoClient;
        public CategoryDOA()
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("Db1");
            var collection = database.GetCollection<BsonDocument>("Category");
            List<BsonDocument> items2 = collection.Find(new BsonDocument()).ToList();

        }
        public void FindAll()
        {

            var database = mongoClient.GetDatabase("Db1");
            var collection = database.GetCollection<BsonDocument>("Category");
            List<BsonDocument> items2 = collection.Find(new BsonDocument()).ToList();
            
        }

        public List<string> data()
        {
            string s = "";
            List<string> a1 = new List<string> { };
            int b, c;
            string[] a = new string[10];
            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Category");
            List<BsonDocument> items2 = collection.Find(new BsonDocument()).ToList();
            for (b = 0; b < items2.Count(); b++)
            {
                for (c = 0; c <= (items2[0].Count()) - 1; c++)
                {
                    a1.Add(((items2.ElementAt(b)).ElementAt(c)).ToString());
                }

            }
            //items2[0].GetValue("Category").ToString();

            int len = items2.Count();
            for (int i = 0; i < len; i++)
            {
                s = s + items2[i].ToString();
            }
            return a1;
        }
    }
}