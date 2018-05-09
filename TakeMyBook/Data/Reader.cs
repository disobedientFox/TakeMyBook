using System.Collections;
using System.Collections.Generic;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class Reader
    {
        public string name { get; set; }
        public int receivedPoints { get; set; }
        public int spentPoints { get; set; }
        public int score { get; set; }
        public ICollection<Book> books { get; set; }
    }
}