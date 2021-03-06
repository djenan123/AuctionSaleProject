﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionSale.Models
{
    public class BidsItem:IEntity
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string UserId { get; set; }
        public double PriceBidded { get; set; }
        public bool IsWinner { get; set; }
        public bool IsDeleted { get; set; }
    }
}
