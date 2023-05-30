using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class CustomIterator <T>
    {
        private T[] array;
        private int index;
        private int size;

        public CustomIterator(T[] array, int index, int size)
        {
            this.array = array;
            this.index = index;
            this.size = size;
        }

        public bool MoveNext()
        {
            index++;
            return index < size;
        }

        public T Current => array[index];

        public T this[int index] => array[index];

        public bool Equals(CustomIterator<T> other)
        {
            return index == other.index;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((CustomIterator<T>)obj);
        }

        public override int GetHashCode()
        {
            return index.GetHashCode();
        }

        public static bool operator ==(CustomIterator<T> iterator1, CustomIterator<T> iterator2)
        {
            if (ReferenceEquals(iterator1, iterator2))
                return true;

            if (ReferenceEquals(iterator1, null) || ReferenceEquals(iterator2, null))
                return false;

            return iterator1.Equals(iterator2);
        }

        public static bool operator !=(CustomIterator<T> iterator1, CustomIterator<T> iterator2)
        {
            return !(iterator1 == iterator2);
        }
    }
}
