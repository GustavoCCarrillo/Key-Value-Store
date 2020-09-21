using System;
using System.Collections.Generic;
using System.Text;

namespace Key_Value_Store
{
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue(string s, object o)
        {
            this.key = s;
            this.value = o;
        }
    }

}
