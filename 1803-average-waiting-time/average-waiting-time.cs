public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        /*
            Calculate wait time for a customer

            Calculate average waiting time based on total wait time
                total customers
        */

        long totalWaitTime = 0;
        long currentTime = 0; 
        foreach(var customer in customers)
        {
            int arrivalTime = customer[0];
            int prepTime = customer[1];

            // determine start time
            long serviceStartTime = Math.Max(currentTime, arrivalTime);

            // determine end time
            long serviceEndTime = serviceStartTime + prepTime;

            // determine wait time
            long waitTime = serviceEndTime - arrivalTime;
            totalWaitTime +=waitTime;

            // reset currentTime
            currentTime = serviceEndTime; 
        }

        return (double) totalWaitTime/customers.Length; 
    }
}