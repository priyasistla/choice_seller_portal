using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoiceProject.Models
{
    public class OrderTable
    {

            private MongoClient mongoClient;


            public bool success;
            public string message;
            public List<List<string>> num;
            public OrderTable(string id)
            {
                var connectionString = "mongodb://localhost:27017";
                mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase("db1");

                 var collection1 = database.GetCollection<BsonDocument>("Customer");
                 List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();

                var collection = database.GetCollection<BsonDocument>("Product");
                List<BsonDocument> items = new List<BsonDocument>();
                var filter = Builders<BsonDocument>.Filter.Eq("Merchant_id", id);
                items = collection.Find(filter).ToList();
                //List<BsonDocument> items1 = collection1.Find(new BsonDocument()).ToList();
                this.success = false;
                try
                {
                    this.num = new List<List<string>>();
                    foreach (var x in items)
                    {                       
                        foreach (var y in items1)
                        {
                          List<string> l = new List<string> { };
                          if (x["P_Name"] ==y["pname"])
                          {                            
                            //l.Add(y["_id"].ToString());
                            l.Add(y["name"].ToString());
                            l.Add(y["phone"].ToString());
                            l.Add(y["pname"].ToString());
                            l.Add(y["email"].ToString());
                            l.Add(y["address"].ToString());
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




