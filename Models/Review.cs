﻿namespace SummerPracticePaul.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
    }
}
