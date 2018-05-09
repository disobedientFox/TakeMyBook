﻿using System;
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
}