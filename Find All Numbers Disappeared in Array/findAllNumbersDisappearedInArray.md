## Given an array nums of n integers where `nums[i]` is in the `range [1, n]`, return an array of all the integers in the range `[1, n]` that do not appear in nums.

So we have an array that contains numbers from 1 to n with some missing numbers (i.e., some places have duplicates to fill the array). our task is to find all these missing numbers in the 
array which are in the range 1 to n.

### **Approach 1** 
  This is a simple brute force method
  1. Deifne a set to store integers.
  2. Add all the numbers in the array to the set.
  3. traverse from 1 to n. for each number check if it is present in the set.
  4. if it is no present, then add that number to our missing numbers list.
  **Time Complexity: `O(n)`** --> traversing the array once each time. (just simple traversal)
  **Space Complexity: `O(n)`** --> Using set.
  ```Java
  public List<Integer> findDisappearedNumbers(int[] nums) {
    HashSet<Integer> set = new HashSet<Integer>();
    for(int num: nums) set.add(num);
      List<Integer> ans = new ArrayList<Integer>();
      for(int i=1; i<=nums.length; i++) {
        if(!set.contains(i)) ans.add(i);
      }
    return ans;
    }
  ```

### **Approach 2**
  We can solve this problem with out using extra space. 
  The idea is to use the indices. since will have numbers from 1 to n in the array, we can use this numbers, translate them to 0-based index (since we have from 1 to n), and then mark the numbers 
  which are present in these index positions as visited. Now, if a number didn't occured in the array, then it's corresponding index number won't be marked. in this we can identify the missing numbers.
  1. Traverse the array from left to right.
  2. At each iteration
     - Take the array element
     - subtract 1 from it (to convert it into 0-based indices). let it be x.
     - now, find the number at the position array[x].
     - check if it is visited. if not, mark as visited.
  3. Now, traverse through the array again and checek whether the elements are visited or not.
  4. if not visited, then that means, it's corresponding array index never occured in the array, which implies that it is missing from the array. so we can add this element to the missing numbers list.
```Java
 public List<Integer> findDisappearedNumbers(int[] nums) {
  List<Integer> ans = new ArrayList<Integer>();
  for(int i=0; i<nums.length; i++) {
    int ind = Math.abs(nums[i])-1;
    if(nums[ind]>0) nums[ind]=-nums[ind];
  }
  for(int i=0; i<nums.length; i++) {
    if(nums[i]>0) ans.add(i+1);
  }
  return ans;
}
```
