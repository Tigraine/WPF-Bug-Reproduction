namespace WPFBugRepro
{
    using System;
    using System.Threading;
    using System.Windows.Input;
    using Caliburn.PresentationFramework.ApplicationModel;
    using Caliburn.PresentationFramework.Screens;

    public class ProductEditModel : Screen
    {
        public IWindowManager WindowManager { get; set; }

        public ProductModel Model { get; set; }

        public ProductEditModel()
        {
            Save = new SaveCommand();
        }

        public void Cancel()
        {
            
        }

        public ICommand Save { get; set; }

        private class SaveCommand : ICommand
        {
            public void Execute(object parameter)
            {
                Console.WriteLine("Save Called from Thread {0}", Thread.CurrentThread.ManagedThreadId);
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }
        
    }
}