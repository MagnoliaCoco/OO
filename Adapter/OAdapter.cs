using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class OAdapter : SO
    {
        private QSortClass sortObj;
        private BSearchClass searchObj;

        public OAdapter()
        {
            sortObj = new QSortClass();
            searchObj = new BSearchClass();
        }

        public int[] Sort(int[] array)
        {
            return sortObj.QSort(array);
        }

        public int Search(int[] array, int key)
        {
            return searchObj.BinarySearch(array, key);
        }
    }
}
