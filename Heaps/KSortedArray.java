import java.util.Collections;
import java.util.PriorityQueue;

public class KSortedArray {
    public static int[] KSortedArrayAsc(int[] arr, int K)
    {
        if(K ==0)
            return arr;
        
        int k = 0;

        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>();

        for(int i = 0; i < arr.length; i++)
        {
            minHeap.add(arr[i]);
            if(minHeap.size() > K)
            {
                arr[k++] = minHeap.poll();
            }
        }
        while(minHeap.size() > 0)
        {
            arr[k++] = minHeap.poll();
        }
        return arr;
    }
    public static int[] KSortedArrayDesc(int[] arr, int K)
    {
        if(K == 0)
            return arr;

        int k = 0;
        PriorityQueue<Integer> maxHeap = new PriorityQueue<Integer>(Collections.reverseOrder());

        for(int i : arr)
        {
            maxHeap.add(i);
            if(maxHeap.size() > K)
            {
                arr[k++] = maxHeap.poll();
            }
        }
        while(maxHeap.size() > 0)
        {
            arr[k++] = maxHeap.poll();
        }
        return arr;
    }
    public static void main(String[] args) {
        int[] arr = { 6, 5, 3, 2, 8, 10, 9 };
        int[] arr1 = { 6, 9, 10, 3, 2, 8, 5 };
        int[] result1 = KSortedArrayAsc(arr, 3);
        int[] result2 = KSortedArrayDesc(arr1, 3);

        System.out.println("Sorted in Ascending Order");
        for(int i : result1)
        {
            System.out.println(i);
        }

        System.out.println("Sorted in Descending Order");
        for(int i : result2)
        {
            System.out.println(i);
        }
    }
}
