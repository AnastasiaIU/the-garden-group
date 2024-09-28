using System.Configuration;
using Model;
using MongoDB.Driver;

namespace DAL
{
    public class BaseDao
    {
        private static string _connectionString;
        private static IMongoClient _mongoClient;
        private static IMongoDatabase _database;

        // References to the collections in the MongoDB instance.
        protected static IMongoCollection<Employee> _employeeCollection;
        protected static IMongoCollection<Ticket> _ticketCollection;

        public BaseDao()
        {
            _connectionString = ConfigurationManager.AppSettings["MongoDB"];

            _mongoClient ??= new MongoClient(_connectionString);
            _database ??= _mongoClient.GetDatabase("NoSQLCluster");
            _employeeCollection ??= _database.GetCollection<Employee>("Employee");
            _ticketCollection ??= _database.GetCollection<Ticket>("Ticket");
        }
    }
}