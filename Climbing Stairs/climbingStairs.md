## [You are climbing a staircase. It takes n steps to reach the top. Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?](https://leetcode.com/problems/climbing-stairs/description/)
 
      Example 1:
      
      Input: n = 2
      Output: 2
      Explanation: There are two ways to climb to the top.
      1. 1 step + 1 step
      2. 2 steps
      Example 2:
      
      Input: n = 3
      Output: 3
      Explanation: There are three ways to climb to the top.
      1. 1 step + 1 step + 1 step
      2. 1 step + 2 steps
      3. 2 steps + 1 step


So, at each step, we can either take one or two steps.
Think about this problem in a recursive.
If i am at nth step, then what are the possible ways to reach there? 
    we can either go nth step from either `(n-1) step` or `(n-2) step`. continue thinking in the same recursive way, to reach `(n-1) step` we can either go from `(n-2) step` or `(n-3) step`.

so `climbTo(n) = climbTo(n-1)+climbTo(n-2)`. This is our recursive equation. 
The above equation can be translated to `no.of ways to reach nth step = no.of ways to reach (n-1)th step + no.of ways to reach (n-2)th step`.

But whats our base condition to stop the recurssion? 
  1. ***Base Case: climbTo(0) = 1***
    This represents the scenario where we haven't taken any steps yet.
    There is exactly one way to do nothing and stay at the ground level—by not taking any steps.
  2. ***Base Case: climbTo(1) = 1***
    If there's only one step to climb, the only possible way to reach the top is by taking a single step.
    So, there is exactly one way to reach step 1.

#### `If we see, this is same as calculating Fibonacci sequence at a particular position.`

```Java
class Solution {
    int[] dp = new int[46];
    public int climbStairs(int n) {
     if(n==0 || n==1) return 1;
     if(dp[n]!=0) return dp[n];
     return dp[n] = climbStairs(n-1)+climbStairs(n-2);   
    }
}
```

***We can find that there are some overlapping sub-problems. so we can use `Dynamic Programming` technique to not to solve this repeating problems again.***
