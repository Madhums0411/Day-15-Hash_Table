using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class LinkedList<K, V> where K : IComparable
    {
       
        public MyMapNode<K, V> head;
        public MyMapNode<K, V> tail;

        public LinkedList()                             
        {
            head = null;
            tail = null;
        }
        public MyMapNode<K, V> Search(K key)            
        {
           
            MyMapNode<K, V> temp = head;               
            while (temp != null)                       
            {
                if (temp.key.Equals(key))
                    return temp;
                temp = temp.next;
            }
            return null;
        }
        public void Append(MyMapNode<K, V> node)
        {
                      
            if (head == null && tail == null)           
            {
                head = node;
                tail = node;
            }
            else
            {
               
                tail.next = node;
                tail = node;
            }
        }
        public bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public MyMapNode<K, V> Pop()
        {
          
            MyMapNode<K, V> temp = head;
            if (head != null)
            {
                
                head = head.next;
            }
            return temp;
        }

        public MyMapNode<K, V> PopLast()
        {
            MyMapNode<K, V> tailTemp = tail;
            if (!IsEmpty())
            {
            
                MyMapNode<K, V> temp = head;
                while (temp.next != tail)
                {
                   
                    temp = temp.next;
                }

                temp.next = null;
                tail = temp;
            }
            return tailTemp;
        }

        public bool DeleteNode(MyMapNode<K, V> DeleteNode)
        {

            MyMapNode<K, V> temp = head;
            if (!IsEmpty())
            {
                
                if (DeleteNode.key.Equals(head.key))
                {
                    Pop();
                    return true;
                }
             
                if (DeleteNode.key.Equals(tail.key))
                {
                    PopLast();
                    return true;
                }
                while (temp != null)
                {
                    
                    if (temp.next != null && temp.next.key.Equals(DeleteNode.key))
                    {
                        temp.next = DeleteNode.next;
                        return true;
                    }
                    temp = temp.next;
                }
            }
            return false;
        }
    }
}
