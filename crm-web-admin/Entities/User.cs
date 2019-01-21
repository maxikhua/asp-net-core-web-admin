using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class User
    {
        [BsonId] public Guid UserId { get; set; }

        [BsonElement("FirstName")] public string FirstName { get; set; }

        [BsonElement("LastName")] public string LastName { get; set; }

        [BsonElement("Email")] public string Email { get; set; }

        [BsonElement("PhoneNumber")] public string PhoneNumber { get; set; }
    }
}