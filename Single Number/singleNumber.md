## [Given a non-empty array of integers nums, every element appears twice except for one. Find that single one. You must implement a solution with a linear runtime complexity and use only constant extra space.](https://leetcode.com/problems/single-number/)
      Example 1:
      
        Input: nums = [2,2,1]
        
        Output: 1
      
      Example 2:
      
        Input: nums = [4,1,2,1,2]
        
        Output: 4
      
      Example 3:
      
        Input: nums = [1]
        
        Output: 1

  Here We can do this by using `HashMap`. but that's not constant space. so we need to think about something else.
  for doing it in constant space, we can make use of `XOR(^)` operator.
  Here is a glimpse of how XOR operator works.
  |Input 1 | Input 2 | Output |
  |--------|---------|--------|
  | 1      | 1       | 0      |
  | 0      | 0       | 0      |
  | 1      | 0       | 1      |
  | 0      | 1       | 1      |

  `Same ^ Same = 0`. we can make use of this property of XOR to find that one non-repeated number.
  we can traverse through array, and xor each element. when we have repeated numbers, each of them get canceled by using XOR (they get canceled only if they are repeated twice and in the question it is given that numbers are repeated eaxctly twice and there is only one non-repeated number. 
  so `XOR` works fine). so by the time we traverse the complete array, we will have only the non-repeated number.
  ###Algorithm
    1. Define a variable `res` that stores first element in the array.
    2. Starting from the second element, traverse through the array.
    3. while doing so, XOR res with the current element in the array. `res = res ^ array[i]`
    4. `res` after traversing the array is the one which is repeated only once.

  ```Java
  public int singleNumber(int[] nums) {
       int res=nums[0];
       for(int i=1; i<nums.length; i++) {
        res ^= nums[i];
       }
       return res;
    }
  ```
