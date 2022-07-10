namespace Intro.ADT.LinkedList
{
    public class LinkedListClass
    {
        public Node First { get; set; }
        public void InsertHead(int data) { 

            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = First;
            First = newNode;
            //o(1) complexity all we doing is assigning operations 
         }


         public Node DeleteFirst(){
             Node temp = First;

             First = First.Next;
             return temp;
         }
    }
}