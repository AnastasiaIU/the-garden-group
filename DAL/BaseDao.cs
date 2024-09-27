using System.Configuration;
using Model;
using MongoDB.Driver;

namespace DAL
{
    public class BaseDao
    {
        protected readonly IMongoCollection<Employee> _employeeCollection;
        protected readonly IMongoCollection<Ticket> _ticketCollection;

        public BaseDao()
        {
            var connectionString = ConfigurationManager.AppSettings["MongoDB"];
            var client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("NoSQLCluster");
            _employeeCollection = database.GetCollection<Employee>("Employee");
            _ticketCollection = database.GetCollection<Ticket>("Ticket");
        }
    }
}