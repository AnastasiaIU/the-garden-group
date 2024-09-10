using System.Configuration;
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
            var userCollection = database.GetCollection<User>("users");

            // CREATE (Insert a new user)
            User testUser = new User("joe", "smith10");
            await userCollection.InsertOneAsync(testUser);
        }

        // Define the User class for the MongoDB documents
        internal class User
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("FirstName")]
            public string FirstName { get; set; }

            [BsonElement("LastName")]
            public string LastName { get; set; }

            public User(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
    }
}
