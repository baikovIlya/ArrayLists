using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _main_array;

        public ArrayList()
        {
            _main_array = new int[10];
            Length = 0;
        }

        public ArrayList(int element)
        {
            Length = 1;
            _main_array = new int[5] { element, 0, 0, 0, 0 };
        }

        public ArrayList(int[] array)
        {
            Length = array.Length;
            _main_array = PlusSize(array);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _main_array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _main_array[index] = value;
            }
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
            if (index > Length || index < 0)
            {
                throw new ArgumentException("This index does not exist");
            }
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

        public void DeleteByIndex(int index = 0)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            if (index > Length || index < 0)
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

        public void DeleteElementsAtTneEnd(int count)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            if (count < 0)
            {
                throw new ArgumentException("Only positive nombers");
            }
            Length -= count;
            SizeCheck(_main_array);
        }

        public void DeleteElementsFromTheBeginning(int count)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            if (count <0)
            {
                throw new ArgumentException("Only positive nombers");
            }
            if (count >= Length)
            {
                Length = 0;
                SizeCheck(_main_array);
            }
            for (int i = 0; i < _main_array.Length-count; i++)
            {
                _main_array[i] = _main_array[i+count];
            }
            Length -= count;
            SizeCheck(_main_array);
        }

        public void DeleteElementsByIndex(int index, int count)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            if (count < 0)
            {
                throw new ArgumentException("Only positive nombers");
            }
            if (index >= Length || index<0)
            {
                throw new ArgumentException("This index does not exist");
            }
            int step = index + count;
            if (step >= Length)
            {
                Length = index;
                SizeCheck(_main_array);
            }
            else
            {
                for (int i = 0; i < Length- step; i++)
                {
                    _main_array[index+i] = _main_array[step + i];
                }
                Length -= count;
                SizeCheck(_main_array);
            }
        }

        public int GetListLength()
        {
            return Length;
        }

        public int SearchFirstIndexByValue(int value)
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int result = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_main_array[i] == value)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public void Reverse()
        {
            int[] tmp_array = new int[(int)(Length*1.5)];
            for (int i = 0; i < Length; i++)
            {
                tmp_array[i] = _main_array[Length-i-1];
            }
            _main_array = tmp_array;
        }

        public int GetMax()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int result = _main_array[0];
            for (int i = 1; i < Length; i++)
            {
                if (result < _main_array[i])
                {
                    result = _main_array[i];
                }
            }
            return result;
        }

        public int GetMin()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int result = _main_array[0];
            for (int i = 1; i < Length; i++)
            {
                if (result > _main_array[i])
                {
                    result = _main_array[i];
                }
            }
            return result;
        }

        public int GetIndexOfMax()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int max_index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_main_array[max_index] < _main_array[i])
                {
                    max_index = i;
                }
            }
            return max_index;
        }

        public int GetIndexOfMin()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int min_index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_main_array[min_index] > _main_array[i])
                {
                    min_index = i;
                }
            }
            return min_index;
        }

        public void SortAscending()
        {
            int[] tmp_array = new int[Length];
            for (int i = 1; i < Length; i++)
            {
                int current = tmp_array[i];
                int location = i - 1;
                while (location >= 0 && tmp_array[location] > current)
                {
                    tmp_array[location + 1] = tmp_array[location];
                    location--;
                }
                tmp_array[location + 1] = current;
            }
            _main_array = tmp_array;
            SizeCheck(_main_array);
        }

        public void SortDesscending()
        {
            int[] tmp_array = new int[Length];
            for (int i = 1; i < Length; i++)
            {
                int current = tmp_array[i];
                int location = i - 1;
                while (location >= 0 && tmp_array[location] < current)
                {
                    tmp_array[location + 1] = tmp_array[location];
                    location--;
                }
                tmp_array[location + 1] = current;
            }
            _main_array = tmp_array;
            SizeCheck(_main_array);
        }

        public int DeleteFirstByValue(int value)
        {
            int result = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_main_array[i] == value)
                {
                    result = i;
                    DeleteByIndex(result);
                    break;
                }
            }
            return result;
        }

        public int DeleteAllByValue(int value)
        {            
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
            if (_main_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _main_array[i - count] = _main_array[i];
                }
            }
            Length -= count;
            SizeCheck(_main_array);
            return count;           
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
