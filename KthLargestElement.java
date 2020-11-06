import java.util.PriorityQueue;

public class KthLargestElement {
    public static int KthLargestValue(int[] arr, int K)
    {
        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>(K);
        for(int i : arr)
        {
            minHeap.add(i);
            if(minHeap.size() > K)
            {
                minHeap.poll();
            }
        }
        return minHeap.peek();
    }
    public static void main(String[] args) {
        int[] arr = { 7, 10, 4, 3, 20, 15 };
        int result = KthLargestValue(arr, 3);
        System.out.println(result);
    }
}
