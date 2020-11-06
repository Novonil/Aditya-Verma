import java.util.Collections;
import java.util.PriorityQueue;


public class KthSmallestElement {

    public static int KthSmallestValue(int[] arr, int K)
    {
        //Generally Sorted in Ascending Order - Collections.ReversedOrder Sorts in Ascending Order
        PriorityQueue<Integer> maxHeap = new PriorityQueue<Integer>(K, Collections.reverseOrder());
        for(int i : arr)
        {
            maxHeap.add(i);
            if(maxHeap.size() > K)
            {
                maxHeap.poll();
            }

        }
        return maxHeap.peek();
    }
    public static void main(String[] args) {
        int[] arr = { 7, 10, 4, 3, 20, 15 };
        
        int result = KthSmallestValue(arr, 3);
        
        System.out.println(result);
    }
}