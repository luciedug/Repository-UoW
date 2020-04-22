using System;
namespace WebApiFinal.Models
{
    public class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
