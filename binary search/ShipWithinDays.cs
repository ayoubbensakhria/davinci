public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int lowest = weights.Max(), highest = weights.Sum();
        while(lowest<highest){
            int middle = (highest + lowest)/2;
            // loaded capacity of current ship
            int currentCapacity = 0;
            // number of ship needed
            int numberShips = 1;
            // simulating loading the weight to ship one by one
            foreach(int weight in weights){
                currentCapacity += weight;
                if(currentCapacity > middle){
                    currentCapacity = weight;
                    numberShips++;
                }
            }
            // we need too many ships, so we need to 
            // increase capacity to reduce num of ships needed
            if(numberShips > days){
                lowest = middle + 1;
            } else {
                highest = middle;
            }

        }
        return lowest;
    }
}