import java.util.Comparator;
import java.util.HashMap;
import java.util.Map;
import java.util.PriorityQueue;

public class FrequencySort {
    public int[] FrequencySortingUsingHeaps(int[] arr)
    {
        int k = 0;
        int[] result = new int[arr.length];
        HashMap<Integer,Integer> frequencyCounter = new HashMap<Integer, Integer>();
        PriorityQueue<PairInteger> minHeap = new PriorityQueue<PairInteger>(new FrequencyComparator());
        
        
        for(int i: arr)
        {
            if(frequencyCounter.containsKey(i))
            {
                frequencyCounter.put(i,frequencyCounter.get(i) + 1);
            }
            else
            {
                frequencyCounter.put(i, 1);
            }
        }
        
        for(Map.Entry<Integer,Integer> i : frequencyCounter.entrySet())
        {
            PairInteger p = new PairInteger(i.getKey(), i.getValue());
            minHeap.add(p);
        }


        while(minHeap.size() > 0)
        {
            
            PairInteger p = minHeap.poll();
            for(int i = 1; i <= p.frequency; i++)
            {
                result[k++] = p.number;
            }
        }
        return result;
    }
    public static void main(String[] args) {
        int[] arr = { 1, 1, 1, 3, 2, 2, 4 };
        FrequencySort km = new FrequencySort();
        int[] result = km.FrequencySortingUsingHeaps(arr);
        for(int i : result)
        {
            System.out.println(i);
        }
    }

    public class FrequencyComparator implements Comparator<PairInteger>
    {
        @Override
        public int compare(PairInteger p1, PairInteger p2)
        {
            return p2.frequency - p1.frequency;
        }
    }

    public class PairInteger
    {
        int number;
        int frequency;

        PairInteger(int num, int freq)
        {
            number = num;
            frequency = freq;
        }
    }
}
