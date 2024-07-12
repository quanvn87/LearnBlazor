using LearnBlazor.Api.Enums;
using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Api.Entities
{
    public class Task1
    {
        [Key]
        public Guid? MHID { get; set; }
        public string MHTEN { get; set; }
        public string MHCODE { get; set; }
        public Decimal GIABANLE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public Priority Priority { get; set; }
    }
}
