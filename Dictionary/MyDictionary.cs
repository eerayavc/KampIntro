using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TK,TV>
    {
        TK[] keys;
        TV[] values;

        public MyDictionary()
        {
            keys = new TK[0];
            values = new TV[0];
        }

        public void Add(TK key, TV value)
        {
            TK[] tempArrayK = keys;
            keys = new TK[keys.Length + 1];
            TV[] tempArrayV = values;
            values = new TV[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempArrayV.Length; i++)
            {
                values[i] = tempArrayV[i];

            }
            values[values.Length - 1] = value;

            Console.WriteLine("İsim:" + key +" " + "Yaş:" + " " +value);
            

        }
        
        public int Count
        {
          
            get { return keys.Length; }
        }
           
    }
}
