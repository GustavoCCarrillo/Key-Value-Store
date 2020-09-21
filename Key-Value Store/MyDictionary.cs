using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace Key_Value_Store
{
    class MyDictionary
    {
        KeyValue[] keys = new KeyValue[4];

       int count = 0;



        public object this[string findkey]
        {
            get
            {
                foreach (var item in keys)
                {
                    if (item.key == findkey)
                    {
                        return item.value;
                    }
                }
                return new KeyNotFoundException();
            }

            set
            {
                bool isNewItem = true;

                for (int i = 0; i < count; i++)
                {
                    if(keys[i].key == findkey)
                    {
                        isNewItem = false;
                        keys[i] = new KeyValue(findkey, value);
                    } 
                }
                if (isNewItem)
                {
                    keys[count++] = new KeyValue(findkey, value);
                }
            }
        }

    }
}
