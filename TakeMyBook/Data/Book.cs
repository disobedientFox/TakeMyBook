using System.ComponentModel.DataAnnotations;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
            
    [DisplayColumn("title")]
    public class Book
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publishingHouse { get; set; }
        public int publishYear { get; set; }
        public int pagesCount { get; set; }
        public bool inStock { get; set; }
    }
}