using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play20200721_DbUzduotis
{
    public class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public ComboItem()
        {

        }
        public ComboItem(int id,string text)
        {
            ID = id;
            Text = text;
        }
    }
}
