namespace MvcidentityBank
{
    public class Account
    {
        public int Id { get; set; }

        public string Number { get; set; }
        public decimal Qty { get; set; }

        //navigation property to CustomUser
        public virtual CustomUser CustomUser { get; set; }
    }
}