## You are given an array prices where `prices[i]` is the price of a given stock on the ith day.<br>You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.<br>Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, `return 0`.

      Example 1:
      
      Input: prices = [7,1,5,3,6,4]
      Output: 5
      Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
      Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
      Example 2:
      
      Input: prices = [7,6,4,3,1]
      Output: 0
      Explanation: In this case, no transactions are done and the max profit = 0.


### ***Approach 1***
  The idea is, if we know the price of a future stock, then we can decide wheter to buy or not.
  To get profit, we need to buy stock at low price and sell it at higher price. so if we know the future higher prices, then we will have a clear picture about the profit.

  1. Define a array `Futures` of size same as input array. this array stores the maximum price after each particular day. 
  2. traverse from the back of price. the last value of futures will be same as last value of prices because there are not stocks after last price.
  3. moving from right to left. we store the maximum in futures by comparing current value in prices with previous value in futures.
  4. in this way we built a array that stores future maximum prices of stocks.
  5. now traverse prices from left to right. at each point, we now we konw the future maximum stock price after that particular day by looking at the futures array.
  6. using that futures array, we can find the difference between future maximum and current price.
  7. store the maximum value and return it after traversing completely.

  ```Java
  public int maxProfit(int[] prices) {
        int n = prices.length;
        int[] future = new int[n];
        future[n-1]=prices[n-1];
        for(int i=n-2; i>=0; i--) {
            if(prices[i]>future[i+1]) future[i]=prices[i];
            else future[i]=future[i+1];
        }
        int profit = 0;
        for(int i=0; i<n-1; i++) {
            profit = Math.max(profit, future[i+1]-prices[i]);
        }
        return profit;
    }
```

### ***Approach 2 - kADANES ALGORITHM***








































