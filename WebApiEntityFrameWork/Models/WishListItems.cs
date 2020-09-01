using System;
using System.Collections.Generic;

namespace WebApiEntityFrameWork.Models
{
    public partial class WishListItems
    {
        public string Id { get; set; }
        public string WishListId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual WishLists WishList { get; set; }
    }
}
