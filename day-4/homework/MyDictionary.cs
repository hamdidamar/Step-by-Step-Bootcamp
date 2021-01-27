using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {

            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int LengthK
        {
            get { return keys.Length; }
        }
        public int LengthV
        {
            get { return keys.Length; }
        }

        public TKey[] Keys
        {
            get { return keys; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
    }
}
