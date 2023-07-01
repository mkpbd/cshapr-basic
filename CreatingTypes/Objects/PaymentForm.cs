namespace Objects
{
    partial class PaymentForm // In auto-generated file
    {

        partial void ValidatePayment(decimal amount);
    }

    partial class PaymentForm // In hand-authored file
    {

        partial void ValidatePayment(decimal amount)
        {
            if (amount > 100)
            {
                Console.WriteLine("Ok, amount", amount);
            }
        }
    }
}