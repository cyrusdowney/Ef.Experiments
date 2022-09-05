using System.ComponentModel.DataAnnotations;

namespace Ef.Experiments.Concurrency.Models
{
    public class PersonConcurency: BaseEntity
    {
        public int Id { get; set; }
        
        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
    }

    public class BaseEntity
    {
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
