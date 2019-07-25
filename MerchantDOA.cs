using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows;

namespace ChoiceProject.Models
{
    public class MerchantDOA
    {
        private MongoClient mongoClient;

        public MerchantDOA()
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);

            var database = mongoClient.GetDatabase("Db1");
            var collection = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items1 = collection.Find(new BsonDocument()).ToList();
        }



        public void create(string name, Int64 phone, string email, string address, string password, string re_password)
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);

            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Merchant");
            //List<BsonDocument> items1 = collection.Find(new BsonDocument()).ToList();
            BsonDocument doc = new BsonDocument();
            doc.Add("M_Name", name);
            doc.Add("M_Phone", phone);
            doc.Add("M_email", email);
            doc.Add("Mshop_Address", address);
            doc.Add("Password", password);
            doc.Add("Re_Password", re_password);
            collection.InsertOne(doc);
        }



        //orders info
        public void createCustomer(string name, Int64 phone, string email,string pname, string address)
        {
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);

            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Customer");
            List<BsonDocument> items1 = collection.Find(new BsonDocument()).ToList();
            BsonDocument doc = new BsonDocument();
            doc.Add("name", name);
            doc.Add("phone", phone);
            doc.Add("email", email);
            doc.Add("pname", pname);
            doc.Add("address", address);
            //doc.Add("Merchant_name", mer_name);
            
            collection.InsertOne(doc);
        }



        //Login
        public class LoginResponse
        {
            public bool success;
            public string message;
            public string uat,name,email,address;
            public string username; // first and last name 

        }

        public LoginResponse authenticate(Int64 phone, string password)
        {
            var lr = new LoginResponse();
            var connectionString = "mongodb://localhost:27017";
            mongoClient = new MongoClient(connectionString);
            List<string> a1 = new List<string> { };
            var database = mongoClient.GetDatabase("db1");
            var collection = database.GetCollection<BsonDocument>("Merchant");
            List<BsonDocument> items2 = new List<BsonDocument>();
            var filter = Builders<BsonDocument>.Filter.Eq("M_Phone", phone) & Builders<BsonDocument>.Filter.Eq("Password", password);

            items2 = collection.Find(filter).ToList();

            if(items2.Count() > 0)
            {
                // successful login
                var merchant = items2[0];
                lr.message = "Success";
                lr.success = true;
                lr.uat = merchant["_id"].ToString();
                lr.name=merchant["M_Name"].ToString();
                lr.email = merchant["M_email"].ToString();
                lr.address = merchant["Mshop_Address"].ToString();

            }
            else
            {
                // failure
            }



            bool code = false;
            string message = "";
            bool b = false;
            lr.success = false;
            foreach (var item in items2)
            {
                if (phone == item["M_Phone"])
                {
                    b = true;
                    if (password == item["Password"])
                    {
                        code = true;
                        message = "Success";
                    }
                    else
                    {
                        message = "incorrect password";
                        MessageBox.Show(message);
                    }
                }
            }
            if (b == false)
            {
                message = "incorrect phone number";
               
            }

            if (code == false)
            {
                message = "incorrect credentials";
                
            }
            else
            {
               

            }

            //a1.Add((code).ToString());
            lr.message = message;


            return lr;
        }
        /*public string RandomString(bool lowerCase)
        {
            int size = 16;
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }*/

    }
}