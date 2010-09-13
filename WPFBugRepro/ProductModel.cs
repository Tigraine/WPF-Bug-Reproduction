namespace WPFBugRepro
{
    using System;
    using System.Threading;
    using Caliburn.PresentationFramework;

    public class ProductModel : PropertyChangedBase
    {
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                NotifyOfPropertyChange(() => Price);
                Console.WriteLine("Update called from Thread {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}