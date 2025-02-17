## Given an array nums containing `n` distinct numbers in the range `[0, n]`, return the only number in the range that is missing from the array.

### ***Approach 1*** ###
  Since we have numbers in range o to n with one missing number, this means that the numbers are continues with just number missing.
  1. Sort the array.
  2. since we have numbers in range from `0` to n in the array, first element in the array should be `0` and last element should be `n`.
  3. traverse through the array from left to right. while doing so, check the difference between two adjacent numbers.
  4. if the difference is equal to `1`. then we continue with our process (which is `step 2`)
  5. if the difference is not equal to `1`, then this means that we have a missing number and its in bettwen this two adjacent numbers.
  6. ***Time Complexity: `O(nlogn)`*** --> Sorting
  7. ***Space Complexity: `O(1)`*** --> no extra space is used.
  ```Java
  public int missingNumber(int[] nums) {
    int sum=nums.length;
    for(int i=0; i<nums.length; i++) {
      sum+=i-nums[i];
    }
    return sum;
  }
  ```

### ***Approach 2*** ###
  Since we have numbers from `0 to n`, we can make use of the sum of first N natural numbers formula. 
  1. calculate the sum of elements in the array.
  2. calculate the sum of n natural numbers using the formula `n*(n+1)/2` where n is the length of the array.
  3. difference between result from `step 2` and `step 1` is our answer (missing number)
  4. ***Time Complexity: `O(n)`*** --> for find the sum of array elements.
  5. ***Space Complexity: `O(1)`*** --> no extra space is used.
```Java
    public int missingNumber(int[] nums) {
      int sum=nums.length;
      for(int i=0; i<nums.length; i++) {
        sum+=nums[i];
      }
      return (n*(n+1)/2)-sum;
    }
  ```

### ***Approach 3*** ###
  This is similar to that of the approach 2. but with out using the `sum of first N natural numbers formula`
  so given we have an array of length n and contains numbers from 0 to n (n+1 numbers).
  we calculate a value while traversing the array by adding the index value and subracting the number in that corresponding number.
  
  reason:
    We have array of size N with values ranging from 0 to N with out repetation. so we can map index of the array to 0 to N numbers. so now when we add index and subtract the correspoding values in the index,
    then by the time we traverse array, we need to get 0 as result if all the numbers from O to N present in the array. but thats not possible because N+1 numbers to sit in N places. so by the time we traverse array,
    we will have a result and this result is the missing number from array
  ```Java
    public int missingNumber(int[] nums) {
       // we are setting to nums.legth because our index goes till nums.length-1 and we will be missing nums.legth in our sum, so we set this to our result.
      int sum=nums.length;
      for(int i=0; i<nums.length; i++) {
        sum+=i-nums[i];
      }
      return sum;
    }
  ```
