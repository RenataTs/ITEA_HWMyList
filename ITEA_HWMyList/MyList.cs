using ListExamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITEA_HWMyList
{
    public class MyList
    {
        private const int DefaultSize = 3;
        private int _currentCount;
        private int[] _array;
        public int[] array => _array;

        public int Length => _currentCount;
        public int Capacity => _array.Length;

        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new ArgumentException();
                }

                return _array[index];
            }
        }

        public MyList()
        {
            _array = new int[DefaultSize];
            _currentCount = 0;
        }

        public void AddBack(int el)
        {
            if (Capacity > Length)
            {
                _array[_currentCount++] = el;
            }
            else
            {
                Array.Resize(ref _array, Capacity + 1);
                _array[_currentCount++] = el;
            }
        }

        public void AddToStart(int el)
        {
            int upperLimit = _currentCount++;
            int lowerLimit = 0;

            if (Capacity > Length)
            {
                Shift.RightShift(ref _array, lowerLimit, upperLimit);
                _array[0] = el;
            }
            else
            {
                Array.Resize(ref _array, Capacity + 1);
                Shift.RightShift(ref _array, lowerLimit, upperLimit);
                _array[0] = el;
            }
        }

        public void InsertByIndex(int el, int index)
        {
            int upperLimit = _currentCount++;
            int lowerLimit = index;

            if (Capacity > Length)
            {
                Shift.RightShift(ref _array, lowerLimit, upperLimit);
                _array[index] = el;
            }
            else
            {
                Array.Resize(ref _array, Capacity + 1);
                Shift.RightShift(ref _array, lowerLimit, upperLimit);
                _array[index] = el;
            }
        }

        public void LastItemDelete()
        {
            --_currentCount;
        }

        public void FirstItemDelete()
        {
            int upperLimit = --_currentCount;
            int lowerLimit = 0;

            Shift.LeftShift(ref _array, lowerLimit, upperLimit);
        }

        public void ItemDeleteByIndex(int index)
        {
            int upperLimit = --_currentCount;
            int lowerLimit = index;

            Shift.LeftShift(ref _array, lowerLimit, upperLimit);
        }

        public void LastNItemsDelete(int n)
        {
            for (int i = 0; i < n; i++)
            {
                --_currentCount;
            }
        }

        public void FirstNItemsDelete(int n)
        {
            int upperLimit = array.Length - 1;
            int lowerLimit = 0;

            while (n > 0)
            {
                Shift.LeftShift(ref _array, lowerLimit, upperLimit);

                --_currentCount;
                --n;
            }
        }

        public void NItemsDeleteByIndex(int n, int index)
        {
            int upperLimit = array.Length - 1;
            int lowerLimit = index;

            while (n > 0)
            {
                Shift.LeftShift(ref _array, lowerLimit, upperLimit);

                --_currentCount;
                --n;
            }
        }

        public int ArrayLength()
        {
            return _currentCount;
        }

        public int RetutnByIndex(int index)
        {
            return _array[index];
        }

        ////private int index;

        ////public int Index
        ////{
        ////    get
        ////    {
        ////        return _array[index];
        ////    }
        ////    set
        ////    {
        ////        for (int i = 0; i < _array.Length; i++)
        ////        {
        ////            if (_array[i] == value)
        ////            {
        ////                index = i;
        ////                break;
        ////            }
        ////        }
        ////    }
        ////}

        //public int RetutnIndexByValue(int value)
        //{
        //    int index = 0;

        //    for (int i = 0; i < _array.Length; i++)
        //    {
        //        if (_array[i] == value)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }

        //    return index;
        //}


    }
}
