﻿using System.Configuration;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class BaseDao
    {
        string connectionString;
        MongoClient client;

        public BaseDao()
        {
            connectionString = ConfigurationManager.AppSettings["MongoDB"];
            client = new MongoClient(connectionString);
            
            Test(client);
        }

        static async Task Test(MongoClient client)
        {
            // TEST
            var database = client.GetDatabase("NoSQLCluster");
            
        }
    }
}
