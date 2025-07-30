﻿namespace TheSDKShop.Domain
{
    public class SubCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public int CategoryId { get; set; }

        public bool IsActive { get; set; }
    }
}
