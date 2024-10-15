using Model;
using MongoDB.Driver;
using System.Configuration;

namespace DAL
{
    #region Orest

    /// <summary>
    /// Abstract class that serves as the base Data Access Object (DAO) for MongoDB interactions.
    /// This class handles the initialization of the MongoDB client, database, and collections for Employee and Ticket entities.
    /// </summary>
    public abstract class BaseDao
    {
        private static string connectionString;
        private static IMongoClient mongoClient;
        private static IMongoDatabase database;

        // References to the collections in the MongoDB instance.
        protected static IMongoCollection<Employee> employeeCollection;
        protected static IMongoCollection<Ticket> ticketCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDao"/> class.
        /// This constructor sets up the MongoDB client, database, and the Employee and Ticket collections if they are not already initialized.
        /// </summary>
        public BaseDao()
        {
            connectionString ??= ConfigurationManager.AppSettings["MongoDB"];
            mongoClient ??= new MongoClient(connectionString);
            database ??= mongoClient.GetDatabase("NoSQLCluster");
            employeeCollection ??= database.GetCollection<Employee>("Employee");
            ticketCollection ??= database.GetCollection<Ticket>("Ticket");
        }
    }

    #endregion
}