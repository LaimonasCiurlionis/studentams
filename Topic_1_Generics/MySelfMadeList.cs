namespace Topic_1_Generics
{
    public class MySelfMadeList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }


        public void AddItem(T item) 
        {
            if (CheckIfNull()) 
            {
                MyArray = IncreaseArraySize();
            }

            if (item != null)
            {
                MyArray[Index] = item;
                Index++;
            }
            else 
            {
                throw new System.ArgumentNullException(nameof(item));
            }
        }

        private bool CheckIfNull() 
        {
            return Index == Size;

            //if (Index == Size)
            //{
            //    return true;
            //}
            //else 
            //{
            //    return false;
            //}
        }

        private T[] IncreaseArraySize() 
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }
    }
}
