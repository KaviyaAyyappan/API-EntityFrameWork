using System;
using System.Collections.Generic;

namespace WebApiEntityFrameWork.Models
{
    public partial class ProductRatings
    {
        public string Id { get; set; }
        public string Comments { get; set; }
        public DateTime? ThisDateTime { get; set; }
        public int? Rating { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
