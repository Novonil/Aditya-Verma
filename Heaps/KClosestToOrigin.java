import java.util.Comparator;
import java.util.PriorityQueue;

public class KClosestToOrigin {
    public int[][] KClosestPointsToOrigin(int[][] arr, int K)
    {
        int k = 0;
        int[][] result = new int[K][2];
        PriorityQueue<PairPairInteger> maxHeap = new PriorityQueue<PairPairInteger>(new DistanceComparator());

        for(int[] i : arr)
        {
            PairPairInteger p = new PairPairInteger((int)(Math.pow(i[0], 2) + Math.pow(i[1], 2)), i[0], i[1]);
            maxHeap.add(p);
            if(maxHeap.size() > K)
            {
                maxHeap.poll();
            }
        }

        for(PairPairInteger p : maxHeap)
        {
            result[k][0] = p.x;
            result[k][1] = p.y;
            k++;
        }
        return result;
    }

    public static void main(String[] args) {
        int[][] arr = {
            { -1, 3 },
            { -2, 2 },
            { 5, 8},
            { 0, 1 }
        };
        KClosestToOrigin kc = new KClosestToOrigin();
        int[][] result = kc.KClosestPointsToOrigin(arr, 2);
        for(int[] i : result)
        {
            System.out.println(" " + i[0] + " " + i[1]);
        }
    }

    public class PairPairInteger
    {
        int distance;
        int x;
        int y;
        PairPairInteger(int distance, int x, int y)
        {
            this.distance = distance;
            this.x = x;
            this.y = y;
        }

    }

    public class DistanceComparator implements Comparator<PairPairInteger>
    {
        @Override
        public int compare(PairPairInteger p1, PairPairInteger p2)
        {
            return p2.distance - p1.distance;
        } 
    }
}
