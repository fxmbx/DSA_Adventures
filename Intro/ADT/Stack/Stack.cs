using System.Runtime.ExceptionServices;

namespace Intro.ADT.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }

        public string[] StackArray { get; set; }
        public int Top { get; set; }

        public Stack(int size){
            this.MaxSize = size;
            this.StackArray = new string[MaxSize];
            this.Top = -1; //becaue array is 0 index -1 will make sure it doesnt skip first element 
        }


        public void Push(string item){
            if(IsFull()){
                throw new IndexOutOfRangeException("Stack don full bros");
            }
              Top++;
                StackArray[Top] = item;

        }

        public string Pop(){
            if(IsEmpty()){
                throw new Exception("Stack is empty");
            }
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public string Peek(){
            if(IsEmpty()){
                throw new IndexOutOfRangeException("nothing de Stack bros");
            }
            return StackArray[Top];
        }

        public bool IsEmpty(){
            return Top == 0;
        }
        public bool IsFull(){
            // System.Console.WriteLine(MaxSize - 1 == Top);
            return MaxSize - 1 == Top;
        }
    }
}