import java.util.PriorityQueue;

public class KLargestElements {
    public static int[] KLargestValues(int[] arr, int K)
    {
        int[] result = new int[K];
        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>(K);

        for(int i : arr)
        {
            minHeap.add(i);
            if(minHeap.size() > K)
            {
                minHeap.poll();
            }
        }

        int k = 0;
        for(int i: minHeap)
        {
            result[k++] = i;
        }
        return result;
    }

    public static void main(String[] args) {
        int[] arr = { 7, 10, 4, 3, 20, 15 };
        int[] result = KLargestValues(arr,3);
        for(int i : result)
        {
            System.out.println(i);
        }
    }
}
