namespace web_shop.Models
{
    public class OrderPosition
    {
        public int OrderPositionID { get; set; }
        public int OrderID { get; set; }
        public int CourseID { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public virtual Course Course { get; set; }
        public virtual Order Order { get; set; }


    }
}