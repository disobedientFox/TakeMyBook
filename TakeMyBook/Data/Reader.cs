using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class Reader
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int receivedPoints { get; set; }
        public int spentPoints { get; set; }
        public ICollection<Book> books { get; set; }
    }
}