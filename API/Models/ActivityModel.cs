﻿namespace API.Models
{
    public class ActivityModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }
    }
}
