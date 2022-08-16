using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeMachine.CLinkLists
{
    class SLinkedLists
    {
        CustomNode head;
        String data;
        CustomNode current;
        int nodeCount;
        List<string> nextlist;
        public void preprend(string data)
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;

            }
            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }

        }
        public List<string> showNext(int count, int listSize)
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }



            return nextlist;

        }
        public void applyProfanityFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean");
                return;

            }

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "*****");
                head.data = replaceString;
                MessageBox.Show(head.data); 
            }

            current = head;

            while (current.Next != null)
            {
                current = current.Next;

                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);
                }
            }
            MessageBox.Show("No vulgar words!");
        }
        public void deleteWithData(string data)
        {

            if (head == null)
            {
                return;
            }

            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            current = head;

            while (current.data != null)
            {
                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Delete");
                    return;
                }
                current = current.Next;
            }
        }
        //public void applyProfanitFilter(string data)
        //{
        //    if (head == null)
        //    {
        //        MessageBox.Show("No List to clean");
        //    }
        //    if (head.data.Contains(data))
        //    {
        //        String replaceString = head.data.Replace(data, "****");
        //        MessageBox.Show(head.data);

        //    }
        //}
        public void appendNode(string data)
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;

            }

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new CustomNode(data);
        }
    }
}
