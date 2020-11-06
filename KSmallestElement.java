import java.util.Collections;
import java.util.PriorityQueue;

public class KSmallestElement {
    public static int[] KSmallestValues(int[] arr, int K){
        int[] result = new int[K];
        PriorityQueue<Integer> maxHeap = new PriorityQueue<Integer>(K, Collections.reverseOrder());
        
        for(int i : arr)
        {
            maxHeap.add(i);
            if(maxHeap.size() > K){
                maxHeap.poll();
            }
        }
        int k = 0;
        for(int i : maxHeap)
        {
            result[k++] = i;
        }
        return result;
    }   
    
    public static void main(String[] args) {
        int[] arr = { 7, 10, 4, 3, 20, 15 };
        int[] result = KSmallestValues(arr,3);
        for(int i : result)
        {
            System.out.println(i);
        }
    }
}
