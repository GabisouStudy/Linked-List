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

        public Node GetPrevious(Node a) {
            if (this.head == a)
                return null;

            Node temp = this.head;
            Node pre_a = null;

            while(temp != null && temp != a){
                pre_a = temp;
                temp = temp.Next;
            }

            if(temp != a){
                throw new ArgumentOutOfRangeException("Maximum: " + this.Count);
            }

            return pre_a;
        }
    }
}
