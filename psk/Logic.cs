using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace psk
{
    class Logic
    {
        public static void Counting(List<MyList> CurrentList, TextBox text)
        {
                char nam = ' ';
                bool q = false;
                foreach (var item in text.Text)
                {
                    q = false;
                    foreach (var itm in CurrentList)
                    {
                        if (itm.name == item)
                        {
                            q = true;
                            nam = itm.name;

                        }
                        else if (itm.name != item && q == false)
                        {
                            q = false;

                        }
                    }
                    if (q == true)
                    {
                        CurrentList.Find(t => t.name == nam).count++;
                    }
                    else
                    {
                        CurrentList.Add(new MyList() { name = item, count = 1 });
                    }
                }
            }
     

        public static void Count(List<MyList> FirstCurrentList, List<MyList> TwoCurrentList, TextBox sl)
        {
                int FirstCount = 0;
                int TwoCount = 0;
                foreach (var item2 in TwoCurrentList)
                {
                    foreach (var item in FirstCurrentList)
                    {
                        if (item.name == item2.name)
                        {
                            FirstCount = item.count / item2.count;
                            if (FirstCount < TwoCount || TwoCount == 0) { TwoCount = FirstCount; }
                        }
                        else { }
                    }
                }
                MessageBox.Show(TwoCount.ToString() + " фраз '" + sl.Text + "' можно собрать из данного текста");
        }
    }
}
