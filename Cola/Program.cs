﻿using System;
 
namespace Pila
{
public class Stack<T>
{
   readonly int m_Size;
   int m_StackPointer = 0;
   public T[] m_Items;
   public Stack():this(4)
   {}
   public Stack(int size)
   {
      m_Size = size;
      m_Items = new T[m_Size];
   }
 
   public void Push(T item)
   {
      if(m_StackPointer >= m_Size){
         
      Console.WriteLine("Error StackOverflow");
      }
      else
      {
          m_Items[m_StackPointer] = item;
          m_StackPointer++;
      }
   }
   public T Pop()
   {
      m_StackPointer--;
      if(m_StackPointer >= 0)
      {
         return m_Items[m_StackPointer];
      }
 
      else
      {
         m_StackPointer = 0;
         throw new InvalidOperationException("Cannot pop an empty stack");
      }
 
   }
 
}
 
class Program
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();
        pila.Push("F");
        pila.Push("I");
        pila.Push("F");
        pila.Push("O");
 
        foreach (string item in pila.m_Items)
        Console.WriteLine(item);
 
        Console.WriteLine("Nueva Pila");
        Console.WriteLine(pila.Pop());
        Console.WriteLine(pila.Pop());
        Console.WriteLine(pila.Pop());
        Console.WriteLine(pila.Pop());
 
    }
}
}
 
 
