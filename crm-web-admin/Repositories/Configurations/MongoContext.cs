using Models;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Repositories.Configurations
{
    public class MongoContext
    {
        public readonly IMongoCollection<User> _userCollection;

        public MongoContext(IConfiguration configuration)
        {
            _userCollection = new MongoClient()
                .GetDatabase("WebApiStore")
                .GetCollection<User>("users");
        }
    }
}