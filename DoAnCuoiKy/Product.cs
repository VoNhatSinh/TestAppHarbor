//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ProductInCategories = new HashSet<ProductInCategory>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public double Price { get; set; }
        public string Review { get; set; }
        public Nullable<int> StockID { get; set; }
        public string Gift { get; set; }
        public string Sale { get; set; }
        public string Vendor { get; set; }
        public Nullable<bool> onSale { get; set; }
        public Nullable<double> oldPrice { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public string ImagePath3 { get; set; }
        public string ImagePath4 { get; set; }
        public bool Show { get; set; }
    
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ProductStock ProductStock { get; set; }
        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
    }
}
