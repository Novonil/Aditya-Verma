import java.util.PriorityQueue;

public class ConnectRopesToMinimizeCost {
    public static int ConnectRopes(int[] arr)
    {
        int cost = 0, ropeLen = 0;
        PriorityQueue<Integer> minHeap = new PriorityQueue<Integer>();
        for(int i : arr)
        {
            minHeap.add(i);
        }

        while(minHeap.size() > 1)
        {
            ropeLen = minHeap.poll() + minHeap.poll();
            cost += ropeLen;
            minHeap.add(ropeLen);
        }
        return cost;
    }

    public static void main(String[] args) {
        int[] arr = {1,2,3,4,5};
        int result = ConnectRopes(arr);
        System.out.println(result);
    }
}
