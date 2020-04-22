using System;
namespace WebApiFinal.Models
{
    public interface IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
