namespace Intro.ADT
{
    public class ArrayOperations
    {
        //Arrays Insertion and Deletion 

        int[] intArry = new int[6];
        int length = 0;
        //inserting at the end of an array take O(1)
        public ArrayOperations()
        {
            for (int i = 0; i < 6; i++)
            {
                intArry[length] = i+1;
                // System.Console.WriteLine(intArry[length]+" "+ length);
                length++;
            }
        }
        public void InsertingToArray(){
            intArry[length]= 8;
            // System.Console.WriteLine(intArry[length]+" "+ length);
            length++;
        }

        public void InsertingAtArrayStart(){
            for (int i = 6; i >=0; i--)
            {
                intArry[i+1] = intArry[i];                
            }
            intArry[0] = 8;

            System.Console.WriteLine("Index: 0, value: {0}\nindex 3: value: {1}",intArry[0], intArry[3]);
        }

        public void InsertingAnywhere(){
            for(int i =4; i>=2; i--){
                intArry[i+1] = intArry[i];
            }
            intArry[2] = 8;
            System.Console.WriteLine(intArry[2]);
            
        }
        public void DeletingFromEndOfArray(){
            length--;
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine(intArry[i]);
            }
        }

        public void DeletingFromArrayStart(){
            for (int i = 4; i < length; i++)
            {
                intArry[i-1] = intArry[i];

            }
        
            length--;
        }
    }


}