namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.AbstractModel;

public abstract class BillingReceiver
{
    public BillingReceiver Next { get; set; } = null;

    public BillingReceiver AddNext(BillingReceiver next)
    {
        this.Next = next;
        return next;
    }

    public virtual Checkout ExecuteServiceBilling(Checkout checkout)
    {
        if (this.Next != null)
            return this.Next.ExecuteServiceBilling(checkout);

        return null;
    }
}
