public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = new (int pos, int spd)[position.Length];
        for(int i=0;i<position.Length;i++) {
            cars[i] = (position[i], speed[i]);
        };

        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));
        int fleets = 0;
        double fleetTime = 0;

        for (int i = 0; i < cars.Length; i++)
        {
            double time = (double)(target - cars[i].pos)/cars[i].spd;
            if(time > fleetTime) {
                fleets++;
                fleetTime = time;
            }
        }
        
        return fleets;
    }
}