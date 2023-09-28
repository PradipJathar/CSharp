namespace AccsessModifiers
{
    public class GoldCustomer : Customer
    {
        public void Offer()
        {           
            int offer = this.OfferPercentage(); // OfferPercentage() method is decleared as Protected in this class so it accessible only in the same class and its derived class.
        }        
    }
}
