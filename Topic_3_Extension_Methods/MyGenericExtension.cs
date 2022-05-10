using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_3_Extension_Methods
{
    public static class MyGenericExtension
    {
        public static T FindAndReturnIfEqual<T>(this List<T> list, T item)
        {
            if (list.Contains(item))
            {
                return item;
            }

            return default;
        }
    }
}
