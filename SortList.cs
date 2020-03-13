using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparador
{
    public class SortList : IComparable<string>
    {

        public string[] SplitArray(string box)
        {
            var ArraySplited = box.Split('\n');

            return ArraySplited;
        }

        public List<string> SortString(List<string> listToSort)
        {
            listToSort.Sort();

            return listToSort;
        }

        public int CompareTo(string other)
        {
            throw new NotImplementedException();
        }
    }
}
