using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciseDesignStack
{
    public class MyStack
    {
        private readonly List<object> list = new List<object>();

        public void Push(object item)
        {
            if (item == null)
            {
                throw new InvalidOperationException("You can not add a null object to the stack.");
            }

            list.Add(item);
        }

        public object Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("There are no elements in the stack.");
            }

            object lastItem = list[list.Count - 1];
            list.Remove(lastItem);

            return lastItem;
        }


        public void Clear()
        {           
            list.Clear();
        }
    }
}
