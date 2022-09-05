using System.ComponentModel.DataAnnotations.Schema;

namespace Ef.Experiments.Casing.Models
{
    [Table("people", Schema = "dbo")]
    public class person
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
