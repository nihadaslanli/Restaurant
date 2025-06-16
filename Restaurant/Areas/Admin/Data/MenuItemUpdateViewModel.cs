﻿using Restaurant.DataContext.Entities;

namespace Restaurant.Areas.Admin.Data
{
   
        public class MenuItemUpdateViewModel
        {
            public int CategoryId { get; set; }
            public required string Name { get; set; }
            public required string Description { get; set; }
            public decimal Price { get; set; }
            public string? ImageUrl { get; set; }
            public bool IsAvailable { get; set; }
            public List<Category>? Categories { get; set; }
        }
    
}
