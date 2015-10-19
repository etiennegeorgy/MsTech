using System;

namespace _1._2_CounterLib
{
    // TODO: Klasse CounterEventArgs implementieren
    public class CounterEventArgs : EventArgs
    {

        public int Count { get; private set; }
        
        public CounterEventArgs(int count)
        {
            // TODO: Complete member initialization
            Count = count;
        }
        
    }

    // TODO: Delegate CounterEventHandler
    public delegate void CounterEventHandler(Counter c, CounterEventArgs args);

    // TODO: Klasse Counter implementieren
    public class Counter
    {
        private int count;

        public int Count
        {
            get { return count; }
            set { 
                count = value;
                if (CountValueChanged == null)
                {
                    return;
                }
                CountValueChanged(this, new CounterEventArgs(count));
            }
        }
        

        public event CounterEventHandler CountValueChanged;

        public Counter(int value = 0)
        {
            Count = value;
        }

        public int Increment()
        {
            return ++Count;
        }

        public int Decrement()
        {
            return --Count;
        }
        
        public void Reset(int value = 0)
        {
            Count = value;
        }
    }
}
