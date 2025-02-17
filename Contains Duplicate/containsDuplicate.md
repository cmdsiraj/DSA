## Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
### **Approach 1**
  1. Sort the Array
  2. Traverse from left to right. while traversing, checking if the current element and the next element are different.
  3.If not, then that means we have a repeted number. so, we return that element since it is repeated.
  4. **Time Complexity: `O(nlogn)`** --> for sorting.
  5. **Space Complexity: `O(1)`** --> We are not using extra space.
  ```Java
  public boolean containsDuplicate(int[] nums) {
    Arrays.sort(nums);
    for(int i=1; i<nums.length; i++) {
      if(nums[i]==nums[i-1]) return true;
    }
    return false;
  }
  ```

### **Approach 2**
  1. Deifne a Set that stores integers
  2. Now traverse the array from left to right
  3. While traversing, check if the element is present in the set.
  4. If element is present, we have a duplicate. so we return that element.
  5. If not, we add that element to our set and go continue our loop.
  6. **Time Complexity: `O(n)`** --> Traversing the array only once.
  7. **Space Complexity: `O(n)`** --> using the extra space *`Set`*
  ```Java
  public boolean containsDuplicate(int[] nums) {
    HashSet<Integer> unique = new HashSet<Integer>();
    for(int num: nums) {
      if(unique.contains(num)) return true;
      unique.add(num);
    }
    return false;
  }
 ```
