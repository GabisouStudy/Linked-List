using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada
{
    class LinkedList
    {
        private Node head;

        public LinkedList(){
            this.head = null;
            //this.count = 0;
        }

        public int Count
        {
            get
            {
                int count = 0;
                Node current = this.head;
                while (current != null)
                {
                    current = current.Next;
                    count++;
                }
                return count;
            }
        }
        public bool Empty {
            get { return this.Count == 0; }
        }

        public object this[int index]{
            get { return this.Get(index); }
        }

        public object Add(int index, object o) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (index > this.Count)
                index = this.Count;

            Node current = this.head;

            if (this.Empty || index == 0){
                this.head = new Node(o, this.head);
            }
            else {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                current.Next = new Node(o, current.Next);
            }

            return o;
        }

        public object Add(object o){
            return this.Add(this.Count, o);
        }

        public object Remove(int index){
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;

            if (index >= this.Count)
                index = this.Count - 1;

            Node current = this.head;
            object result = null;

            if(index == 0){
                result = current.Data;
                this.head = current.Next;
            }
            else{
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            return result;
        }

        public void Clear(){
            this.head = null; 
        }

        public int IndexOf(object o){
            Node current = this.head;

            for (int i = 0; i < this.Count; i++) {
                if (current.Data.Equals(o))
                    return i;

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(object o){
            return this.IndexOf(o) >= 0;
        }

        public object Get(int index){
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);

            if (this.Empty)
                return null;

            if (index > this.Count)
                index = this.Count - 1;

            Node current = this.head;

            for(int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }
        public void Change(Node n1, Node n2) {
            if (this.head == null || n1 == null || n2 == null)
                throw new ArgumentOutOfRangeException("Count: " + this.Count);

            Node pre_n1 = GetPrevious(n1);
            Node pre_n2 = GetPrevious(n2);

            if (pre_n1 != null) pre_n1.Next = n2;
            if (pre_n2 != null) pre_n2.Next = n1;

            Node temp;

            temp = n1.Next;
            n1.Next = n2.Next;
            n2.Next = temp;

            if (this.head == n1){
                this.head = n2;
            }
            else if(this.head == n2){
                this.head = n1;
            }
        }

        public Node GetPrevious(Node n) {
            if (this.head == n)
                return null;

            Node temp = this.head;
            Node pre_n = null;

            while(temp != null && temp != n){
                pre_n = temp;
                temp = temp.Next;
            }

            if(temp != n){
                throw new ArgumentOutOfRangeException("Maximum: " + this.Count);
            }

            return pre_n;
        }
    }
}
