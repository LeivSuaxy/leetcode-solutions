// Reverse Integer

var reverse = function(x) {
    if(x === 0) return 0;

    if(x/10 === 0) return x;

    let temp;
    let isFirstNumber = true;
    let final = '';
    let isNegative = false;
    let newNumber;

    if(x < 0){
        x *= -1;
        isNegative = true;
    }

    while(x > 0){
        temp = x % 10;
        x /= 10;
        if (isFirstNumber && temp === 0){
            isFirstNumber = false;
            continue;
        }
        final += temp.toString();
        if (isFirstNumber) isFirstNumber = false;
    }

    newNumber = Number.parseInt(final);

    if (isNegative) newNumber = -newNumber;

    if (newNumber > Number.MAX_SAFE_INTEGER || newNumber < Number.MAX_SAFE_INTEGER ) return 0;

    return newNumber;
};