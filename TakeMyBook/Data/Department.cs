using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string openingHours { get; set; }
        public ICollection<Book> books { get; set; }
    }
}