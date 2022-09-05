using System.ComponentModel.DataAnnotations;

namespace Ef.Experiments.Concurrency.Models
{
    public class Person
    {
        public int Id { get; set; }
        
        [ConcurrencyCheck]
        public string FirstName { get; set; }

        [ConcurrencyCheck]
        public string LastName { get; set; }
    }
}
