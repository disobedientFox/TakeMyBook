using System.Collections.Generic;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class Department
    {
        public string address { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string openingHours { get; set; }
        public ICollection<Book> books { get; set; }
    }
}