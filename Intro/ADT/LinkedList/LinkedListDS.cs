namespace Intro.ADT.LinkedList
{
    public class LinkedListDS
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

         public void Display(){
             System.Console.WriteLine("Iteratin list ");
             Node current = First;
             while(current !=null){
                 current.DisplayNode();
                 current = current.Next;
             }
         }

         public void InsertLast(int data){
             Node current = First;
             while(current.Next != null){
                 current = current.Next;
             }
             Node newNode = new Node();
             newNode.Data = data;
             current.Next = newNode;
         }
    }
}