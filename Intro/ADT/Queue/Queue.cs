namespace Intro.ADT.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; } //cause we de use array 

        public int[] QueueArray { get; set; }
        private int Front { get; set; }
        private int Rear {get; set;}
        private int NItems {get;set;}


        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
        }

        public void Enquque(int item){
            Rear++;
            QueueArray[Rear] = item;
            // Front++;
            NItems++;
        }

        public int Dequeue(){
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize){
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek(){
            return QueueArray[Front]; 
        }
    }
}