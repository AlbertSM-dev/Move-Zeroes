public class Solution {
    public void MoveZeroes(int[] nums) {
        var zero = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                (nums[zero], nums[i]) = (nums[i], nums[zero]);
                zero++;
            }
        }

    }
}
