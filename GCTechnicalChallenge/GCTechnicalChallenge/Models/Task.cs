using System;
using System.Collections.Generic;

#nullable disable

namespace GCTechnicalChallenge.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsComplete { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
