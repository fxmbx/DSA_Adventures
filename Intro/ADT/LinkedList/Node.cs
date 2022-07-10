namespace Intro.ADT.LinkedList
{
    public class Node
    {
        public int Data { get; set; }   
        public Node? Next { get; set; }
        public void DisplayNode() {
            System.Console.WriteLine(Data);
        }
    }
}