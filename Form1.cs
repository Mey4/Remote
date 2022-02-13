using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    class NodeDoubleLinkedList<T> where T: IComparable<T>
    {
        public NodeDoubleLinkedList(T value)
        {
            Value = value;
        }
        public NodeDoubleLinkedList(T value, NodeDoubleLinkedList<T> next)
        {
            Value = value;
            Next = next;
        }
        public T Value { get; set; }
        public NodeDoubleLinkedList<T> Next { get; set; }
        public NodeDoubleLinkedList<T> Previous { get; set; }
        public static bool operator >(NodeDoubleLinkedList<T> n1, NodeDoubleLinkedList<T> n2)
        {
            if (n1.Value.CompareTo(n2.Value) > 0)
                return true;
            else
                return false;
        }
        public static bool operator <(NodeDoubleLinkedList<T> n1, NodeDoubleLinkedList<T> n2)
        {
            if (n1.Value.CompareTo(n2.Value) < 0)
                return true;
            else
                return false;
        }
        public static bool operator <=(NodeDoubleLinkedList<T> n1, NodeDoubleLinkedList<T> n2)
        {
            int compare = n1.Value.CompareTo(n2.Value);
            if (compare <= 0)
                return true;
            else
                return false;
        }
        public static bool operator >=(NodeDoubleLinkedList<T> n1, NodeDoubleLinkedList<T> n2)
        {
            int compare = n1.Value.CompareTo(n2.Value);
            if (compare >= 0)
                return true;
            else
                return false;
        }
    }



    class Utilities<T> where T:IComparable<T>
    {
        public static DoubleLinkedList<int> RandomInt(int size)
        {
            var list = new DoubleLinkedList<int>();
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Push(rnd.Next(-1000, 1000));
            }
            return list;
        }
        public static DoubleLinkedList<double> RandomDouble(int size)
        {
            var list = new DoubleLinkedList<double>();
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Push(rnd.NextDouble()*rnd.Next(1, 1000));
            }
            return list;
        }
        public static DoubleLinkedList<string> RandomString(int size)
        {
            var list = new DoubleLinkedList<string>();
            var rnd = new Random();
            string tstr = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < rnd.Next(1, 5); j++)
                {
                    tstr += (char)rnd.Next(65, 91);
                }
                list.Push(tstr);
                tstr = "";
            }
            return list;
        }
        public static DoubleLinkedList<T> Copy(List<T> list)
        {
            DoubleLinkedList<T> list1 = new DoubleLinkedList<T>();
            for (int i = 0; i < list.Count; i++)
                list1.Push(list[i]);
            return list1;
        }
        public static DoubleLinkedList<T> SortVar(DoubleLinkedList<T> list, DoubleLinkedList<T> sort)
        {

            DoubleLinkedList<T> listsorted = new DoubleLinkedList<T>();
            listsorted = sort.Sorting(list);
            return listsorted;
        }
    }
    class DoubleLinkedList<T> where T : IComparable<T>
    {
        public NodeDoubleLinkedList<T> head;
        public NodeDoubleLinkedList<T> tail;
        public int Count;
        public T this[int index]
        {
            get
            {
                if (index < 0) throw new ArgumentOutOfRangeException();
                NodeDoubleLinkedList<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    if (current.Next == null)
                        throw new ArgumentOutOfRangeException();
                    current = current.Next;
                }
                return current.Value;
            }
        }
        public void Push(T value)
        {
            NodeDoubleLinkedList<T> node = new NodeDoubleLinkedList<T>(value);
            NodeDoubleLinkedList<T> temp = head;
            head = node; 
            head.Next = node; 
            head.Next = temp; 
            if (Count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = head;
            }
            Count++;
        }
        public void Replace(NodeDoubleLinkedList<T> oldItem, NodeDoubleLinkedList<T> newItem)
        {
            NodeDoubleLinkedList<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(oldItem))
                {
                    current.Value = newItem.Value;
                }
                current = current.Next;
            }
        }
        public void insert(T value, int index)
        {
            NodeDoubleLinkedList<T> currentNode = head;
            for (int i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.Next;
            }
            NodeDoubleLinkedList<T> node = new NodeDoubleLinkedList<T>(value, currentNode.Next);
            currentNode.Next = node;
            Count++;
        }
        public void Swap(DoubleLinkedList<T> list, int firstIndex, int secondIndex)
        {
            if (firstIndex == secondIndex)
                return;

            if (firstIndex > secondIndex)
                (firstIndex, secondIndex) = (secondIndex, firstIndex);

            int i = 0;

            var leftNode = list.head;
            while (++i < firstIndex)
                leftNode = leftNode.Next;

            var rightNode = leftNode.Next;
            while (++i < secondIndex)
                rightNode = rightNode.Next;

            list.Replace(leftNode, rightNode);
            list.Replace(rightNode, leftNode);
        }
        public void ClearAll()
        {
            head = null;
            tail = null;
            Count = 0;
        }
    }

    abstract class sortAbstract<T> where T : IComparable<T>
    {
        public abstract NodeDoubleLinkedList<T> Sorting(NodeDoubleLinkedList<T> unsorted);
    }

    class sortingInsert<T>: sortAbstract<T> where T: IComparable<T>
    {
        public int comparison=0, shift=0;
        public override NodeDoubleLinkedList<T> Sorting(NodeDoubleLinkedList<T> list)
        {
            int i = 0;
            while ([i] != 0)
            {
               
            }
        }
    }
}
