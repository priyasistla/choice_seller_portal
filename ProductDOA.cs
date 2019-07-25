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
    public class ProductDOA
    {
        private MongoClient mongoClient;


        public ProductDOA()
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Product");
            List<BsonDocument> items = collection.Find(new BsonDocument()).ToList();
            var collection1 = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();

        }

         public List<string> generate(string name)
         {
         var connectionString = "mongodb://localhost:27017";
         mongoClient = new MongoClient(connectionString);
         var database = mongoClient.GetDatabase("db1");
         var collection = database.GetCollection<BsonDocument>("Product");
         List<BsonDocument> items = collection.Find(new BsonDocument()).ToList();
         var collection1 = database.GetCollection<BsonDocument>("Merchant");
         List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();

         String s = "";
             List<string> l = new List<string> { };
             foreach (var x in items)
             {
                 if (x["P_Name"].ToString() == name)
                 {
                     s = x["Merchant_id"].ToString();

                     foreach (var y in items1)
                     {
                         if (y[0].ToString() == s)
                         {
                             l.Add(y["M_Name"].ToString());
                             l.Add(x["P_Price"].ToString());

                         }
                     }
                 }
             }
             return l;

         }

        public List<string> display(string id)
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Product");
            List<BsonDocument> items = collection.Find(new BsonDocument()).ToList();
            var collection1 = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();
            //String s = "";
            List<string> l = new List<string> { };
            foreach (var y in items)
            {
                if (y["Merchant_id"].ToString() == id)
                {
                     
                    l.Add(y["P_Name"].ToString());
                    l.Add(y["P_Price"].ToString());
                   

                }
            }
            return l;
        }
         



        public List<string> FindAll()
         {
             string s = "";
             List<string> a1 = new List<string> { };
             int b, c;
             string[] a = new string[10];
             var database = mongoClient.GetDatabase("db1");
             var collection = database.GetCollection<BsonDocument>("Product");
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

         public void pcreate(string pname,Int32 productprice,string category,string subcategory,string physicalprop,string phonenumber)
         {
             var connectionString = "mongodb://localhost:27017";
             mongoClient = new MongoClient(connectionString);

             var database = mongoClient.GetDatabase("db1");
             var collection = database.GetCollection<BsonDocument>("Product");
             List<BsonDocument> items1 = collection.Find(new BsonDocument()).ToList();
            var collection1 = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items = collection1.Find(new BsonDocument()).ToList();
            var id="";
            foreach (var z in items)
            {
                if (z["M_Phone"].ToString() == phonenumber)
                {
                    id = z["_id"].ToString();
                }
            }
            BsonDocument doc = new BsonDocument();
             doc.Add("P_Name", pname);
             doc.Add("P_Price", productprice);
             doc.Add("Category", category);
             doc.Add("Sub_category", subcategory);
             doc.Add("Physical_prop", physicalprop);
             doc.Add("Merchant_id", id);
             collection.InsertOne(doc);
         }


     }

    }
         