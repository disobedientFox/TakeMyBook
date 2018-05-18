using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class Trade
    {
        [Key]
        public int id { get; set; }
        public Book book { get; set; }
        public Reader reader { get; set; }
        public Department department { get; set; }
        public DateTime date { get; set; }
        public bool IsGiven { get; set; }
    }

    public class TradeView
    {
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Book")]
        public string book { get; set; }
        [DisplayName("Department")]
        public string department { get; set; }
        [DisplayName("Date")]
        public DateTime date { get; set; }
        [DisplayName("Was given")]
        public bool IsGiven { get; set; }
    }
}