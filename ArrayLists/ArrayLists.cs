using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    public class ArrayLists
    {
        public int Length { get; private set; }

        private int[] _main_array;

        public ArrayLists()
        {
            _main_array = new int[10];
            Length = 0;
        }

        public ArrayLists(int element)
        {
            Length = 1;
            _main_array = new int[5] { element, 0, 0, 0, 0 };
        }

        public ArrayLists(int[] array)
        {
            Length = array.Length;
            _main_array = PlusSize(array);
        }

        public void AddLast(int last_elemet)
        {
            SizeCheck(_main_array);
            _main_array[Length] = last_elemet;
            Length++;
        }

        public void AddFirst(int first_element)
        {
            MoveRight();
            _main_array[0] = first_element;
            Length++;
        }

        public void AddByIndex(int new_element, int index)
        {
            MoveRight(index);
            _main_array[index] = new_element;
            Length++;
        }

        public void DeleteLast()
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            Length--;
            SizeCheck(_main_array);
        }

        public void DeleteFirst()
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            for (int i = 0; i < Length; i++)
            {
                _main_array[i] = _main_array[i + 1];
            }
            Length--;
            SizeCheck(_main_array);
        }

        public void DeleteByIndex(int index)
        {
            if (index > Length)
            {
                throw new ArgumentException("This index does not exist");
            }
            Length--;
            for (int i = index; i < Length; i++)
            {
                _main_array[i] = _main_array[i+1];
                
            }
            SizeCheck(_main_array);
        }










        private int[] PlusSize(int[] array)
        {
            int result_length = (int)(array.Length*1.5+1);
            int[] result = new int[result_length];
            for (int i = 0; i < result_length; i++)
            {
                if (i < array.Length)
                {
                    result[i] = array[i];
                }
                else
                {
                    result[i] = 0;
                }
            }    
            return result;
        }

        private int[] MinusSize(int[] array)
        {
            int result_length = (int)(Length*1.5+1);
            int[] result = new int[result_length];
            for (int i = 0; i < result_length; i++)
            {
                result[i] = array[i];
            }
            return result;
        }
        
        private void SizeCheck(int[] array)
        {
            if (_main_array.Length <= Length)
            {
                _main_array = PlusSize(_main_array);
            }
            else if (_main_array.Length > Length*2)
            {
                _main_array = MinusSize(_main_array);
            }
        }

        private void MoveRight(int index = 0)
        {
            SizeCheck(_main_array);
            int[] newArray = new int[_main_array.Length+1];
            for (int i = 0; i < _main_array.Length; i++)
            {
                newArray[i] = _main_array[i];
            }
            for (int i = index; i<_main_array.Length; i++)
            {
                newArray[i+1] = _main_array[i];
            }
            newArray[index] = 0;
            _main_array = newArray;
        }

    }
}
