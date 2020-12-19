using System;
using System.Collections.Generic;

class Stack
{
    private List<Object> stack = new List<Object>();
    public void Push(object obj)
    {
        if (obj != null)
        {
            stack.Add(obj);
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public object StackCount()
    {
        return stack.Count;
    }

    public object Pop()
    {
        if (stack.Count != 0)
        {
            stack.RemoveAt(stack.Count - 1);
        }
        else
        {
            throw new InvalidOperationException();
        }

        return stack.Count + 1;
    }

    public void Clear()
    {
        if (stack.Count != 0)
        {
            stack.Clear();
        }
        else
        {
            throw new InvalidOperationException();
        }
    }  
}