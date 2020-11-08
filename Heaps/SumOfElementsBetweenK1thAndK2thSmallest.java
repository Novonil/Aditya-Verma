import java.util.Collection;
import java.util.Collections;
import java.util.PriorityQueue;
import java.util.concurrent.PriorityBlockingQueue;

public class SumOfElementsBetweenK1thAndK2thSmallest {
    public static int SumBetweenTwoPositions(int[] arr, int K1, int K2)
    {
        int sum = 0;
        int start = 0, end = 0;
        PriorityQueue<Integer> maxHeap = new PriorityQueue<Integer>(Collections.reverseOrder());
        PriorityQueue<Integer> maxHeap1 = new PriorityQueue<Integer>(Collections.reverseOrder());
        
        for(int i : arr)
        {
            maxHeap.add(i);
            if(maxHeap.size() > K1)
            {
                maxHeap.poll();
            }
        }
        for(int i: arr)
        {
            maxHeap1.add(i);
            if(maxHeap1.size() > K2)
            {
                maxHeap1.poll();
            }
        }
        start = K1 < K2 ? maxHeap.peek() : maxHeap1.peek();
        end = K1 < K2 ? maxHeap1.peek() : maxHeap.peek();

        for(int i : arr)
        {
            if(i > start && i < end)
            {
                sum += i;
            }
        }
        return sum;
    }
    public static void main(String[] args) {
        int[] arr = { 1, 3, 12, 5, 15, 11};
        int sum = SumBetweenTwoPositions(arr, 3,6);
        System.out.println(sum);
    }
}
