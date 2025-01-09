// Two Sum

var twoSum = function(nums, target) {
    let arrayNums = [];

    for(let i = 0; i < nums.length - 1; i++){
        for(let j = i + 1; j < nums.length; j++ ){
            if ( target - nums[j] == nums[i]){
                arrayNums[0] = i;
                arrayNums[1] = j;
                return arrayNums;
            }
        }
    }

    return arrayNums;
};