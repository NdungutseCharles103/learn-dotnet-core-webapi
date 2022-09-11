using MongoDB.Bson;
using Crud_Mongodb.Bson.Serialization.Attributes;

namespace Crud_Mongodb.Models
{
    // [BsonIgnoreExtraElements] use this when there aother fields in db
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("graduated")]
        public bool isGraduated { get; set; }

        [BsonElement("courses")]
        public string[]? Courses { get; set; } 

        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;

        [BsonElement("age")]
        public int age { get; set; }
    }

}