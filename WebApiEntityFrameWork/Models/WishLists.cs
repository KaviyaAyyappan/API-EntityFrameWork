using System;
using System.Collections.Generic;

namespace WebApiEntityFrameWork.Models
{
    public partial class WishLists
    {
        public WishLists()
        {
            WishListItems = new HashSet<WishListItems>();
        }

        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<WishListItems> WishListItems { get; set; }
    }
}
