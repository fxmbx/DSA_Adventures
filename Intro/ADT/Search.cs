
namespace Intro.ADT
{
    public class Search
    {
        public bool LinearSearch(int[] array, int key){
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == key){
                    return true;
                }
            }
                return false;
        }

      public int BinarySearch(int[] sortedArray, int value){
          int start =0;
          int end = sortedArray.Length;

          while(start < end){

              int midpoint = (start+end)/2;

              if(sortedArray[midpoint]== value){
                  return midpoint;
              }else if(sortedArray[midpoint] < value){
                  start = midpoint +1;
              }
              else{
                  end = midpoint;
              }

          }
          return -1;
      }

    }
}


