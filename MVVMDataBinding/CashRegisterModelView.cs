using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister; //makes items in namespace available without using full name, but must include the file in project

namespace MVVMDataBinding
{
    class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses (private because this code should be the only thing manipulating this drawer)
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        //Properties to act as proxies between drawer and UI

        /// <summary>
        /// The current total value contained in the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Count of pennies contained in the drawer
        /// </summary>
        public int Pennies {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                //drawer.Pennies = value; This does not work because Pennies is read-only
                var quantity = value - drawer.Pennies; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else  drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }
        /// <summary>
        /// Count of nickels contained in the drawer
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Count of Dimes contained in the drawer
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }
        /// <summary>
        /// Count of Quarters contained in the drawer
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }
        /// <summary>
        /// Count of HalfDollars contained in the drawer
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }
        /// <summary>
        /// Count of Dollars contained in the drawer
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }
        /// <summary>
        /// Count of Ones contained in the drawer
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }
        /// <summary>
        /// Count of Twos contained in the drawer
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }
        /// <summary>
        /// Count of Fives contained in the drawer
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }
        /// <summary>
        /// Count of Tens contained in the drawer
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }
        /// <summary>
        /// Count of Twenties contained in the drawer
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }
        /// <summary>
        /// Count of Fifties contained in the drawer
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }
        /// <summary>
        /// Count of Hundreds contained in the drawer
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds; //computes difference in desired and current number of pennies
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Helper method to invoke property changed event
        /// </summary>
        /// <param name="denomination"></param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }


    }
}
