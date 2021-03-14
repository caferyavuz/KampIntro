using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {
        K[] key;
        V[] value;
        K[] tempKey;
        V[] tempValue;
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K k,V v)
        {
            tempKey = key;
            tempValue = value;
            key = new K[tempKey.Length+1];
            value = new V[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = k;
            value[value.Length - 1] = v;
        }
        public int Count
        {
            get { return key.Length; }
        }
    }
}
