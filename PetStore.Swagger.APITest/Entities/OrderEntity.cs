using System;

namespace PetStore.Swagger.APITest.Entities
{
    public class OrderEntity
    {
        public long id { get; set; }
        public int petId { get; set; }
        public int quantity { get; set; }
        public DateTime shipDate { get; set; }
        public string status { get; set; }
        public bool complete { get; set; }
    }
}
