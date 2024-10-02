using Model;
using MongoDB.Driver;
using System.Configuration;

namespace DAL
{
    public abstract class BaseDao
    {
        private static string connectionString;
        private static IMongoClient mongoClient;
        private static IMongoDatabase database;

        // References to the collections in the MongoDB instance.
        protected static IMongoCollection<Employee> employeeCollection;
        protected static IMongoCollection<Ticket> ticketCollection;

        public BaseDao()
        {
            connectionString ??= ConfigurationManager.AppSettings["MongoDB"];
            mongoClient ??= new MongoClient(connectionString);
            database ??= mongoClient.GetDatabase("NoSQLCluster");
            employeeCollection ??= database.GetCollection<Employee>("Employee");
            ticketCollection ??= database.GetCollection<Ticket>("Ticket");
        }
    }
}