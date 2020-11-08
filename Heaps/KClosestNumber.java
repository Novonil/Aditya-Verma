import java.util.Comparator;
import java.util.PriorityQueue;

public class KClosestNumber {
    public int[] KClosestNumbersToANumber(int[] arr, int n, int K)
    {
        int k = 0;
        int[] result = new int[K];
        PriorityQueue<PairInteger> maxHeap = new PriorityQueue<PairInteger>(new DistanceComparator());

        for(int i : arr)
        {
            PairInteger p = new PairInteger(Math.abs(i-n), i);
            maxHeap.add(p);;
            if(maxHeap.size() > K)
            {
                maxHeap.poll();
            }
        }

        while(maxHeap.size() > 0)
        {
            result[k++] = maxHeap.poll().element;
        }
        return result;
    }
    public static void main(String[] args) {
        int[] arr = { 5, 6 ,7, 8, 9 };
        KClosestNumber KC = new KClosestNumber();
        int[] result = KC.KClosestNumbersToANumber(arr, 7, 3);
        for(int i : result)
        {
            System.out.println(i);
        }
    }
    public class PairInteger
    {
        int difference;
        int element;
        PairInteger(int diff, int ele)
        {
            this.difference = diff;
            this.element = ele;
        }
    }
    public class DistanceComparator implements Comparator<PairInteger>
    {
        @Override
        public int compare(PairInteger p1, PairInteger p2)
        {
            if(p1.difference < p2.difference)
            {
                return 1;
            }
            else if(p1.difference > p2.difference)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}


