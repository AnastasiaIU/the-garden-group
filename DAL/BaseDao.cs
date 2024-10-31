using Model;
using MongoDB.Driver;
using System.Configuration;

namespace DAL
{
    #region Orest and Sia

    /// <summary>
    /// Abstract class that serves as the base Data Access Object (DAO) for MongoDB interactions.
    /// This class handles the initialization of the MongoDB client, database, and collections for Employee and Ticket entities.
    /// </summary>
    public abstract class BaseDao<T>
    {
        private static string? connectionString;
        private static IMongoClient? mongoClient;
        private static IMongoDatabase? database;
        private static MongoClientSettings? mongoSettings;

        // References to the collections in the MongoDB instance.
        protected static IMongoCollection<Employee>? employeeCollection;
        protected static IMongoCollection<Ticket>? ticketCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDao"/> class.
        /// Refreshes the MongoDB configuration section and attempts to establish a connection 
        /// with the MongoDB server using the connection string from the application configuration.
        /// </summary>
        public BaseDao()
        {
            // Refresh the MongoDB configuration section to ensure the latest settings are loaded.
            ConfigurationManager.RefreshSection("MongoDB");

            try
            {
                connectionString = ConfigurationManager.AppSettings["MongoDB"];
                mongoSettings = MongoClientSettings.FromConnectionString(connectionString);
                mongoSettings.ConnectTimeout = TimeSpan.FromSeconds(5);
                mongoClient = new MongoClient(connectionString);
                database = mongoClient.GetDatabase("NoSQLCluster");
                employeeCollection = database.GetCollection<Employee>("Employee");
                ticketCollection = database.GetCollection<Ticket>("Ticket");
            }
            catch (Exception)
            {
                // In a real app, errors or exceptions are logged here for troubleshooting which is out of scope for this project.
            }
        }

        /// <summary>
        /// Gets a value indicating whether the database connection was successfully established.
        /// </summary>
        /// <returns>
        /// True if the database is initialized and accessible; otherwise, false.
        /// </returns>
        public bool IsDatabaseInitiated
        {
            get { return database != null; }
        }

        // This method is used to check if the internet connection is available. It tries to list the database names and returns true if successful.
        public async Task<bool> IsInternetAvailable()
        {
            try
            {
                await mongoClient.ListDatabaseNamesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    #endregion
}