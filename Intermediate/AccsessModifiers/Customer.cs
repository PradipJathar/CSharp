namespace AccsessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Public - Accessible form everywhere.
        public void Promote()
        {
            int rating = CalculateRating();         // CalculateRating() method is decleared as Private in this class so it accessible only in this class.

            int offer = OfferPercentage();          // OfferPercentage() method is decleared as Protected in this class so it accessible only in this class and its derived class.
        }


        // Private - Accessible only form the class.
        private int CalculateRating()
        {
            return 0;
        }


        // Protected - Accessible only for the class and its derived class.
        protected int OfferPercentage()
        {
            return 20;
        }
    }
}
