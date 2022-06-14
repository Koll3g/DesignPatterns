using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        public List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }


        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {  
                str += str + this._parts[i]+ ", ";
            }

            return "Product parts: " + str + "\r\n"; 
        }


    }
}