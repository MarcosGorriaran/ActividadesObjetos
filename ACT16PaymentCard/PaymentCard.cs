

namespace ACT16PaymentCard
{
    public class PaymentCard
    {
        private double balance;

        public double Balance { get; set; }
        public PaymentCard(double openingBalance)
        {
            this.Balance = openingBalance;
        }
        public override string ToString()
        {
            return $"The card has a balance of {this.Balance} euros";
        }
    }

}
