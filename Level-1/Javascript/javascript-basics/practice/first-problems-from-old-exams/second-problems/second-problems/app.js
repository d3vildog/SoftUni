function solve(arr) {
    var numbers = arr[0].split(/[^0-9]+/).filter(Boolean);
    var strHex = [];
    
    for (var i = 0; i < numbers.length; i++) {
        strHex[i] = "0x" + padLeft(parseInt(numbers[i]).toString(16).toUpperCase(), 4);
    }
    
    function padLeft(num, size) {
        var s = num + "";
        while (s.length < size) s = "0" + s;
        return s;
    }
    
    return strHex.join("-");
}

solve(["5tffwj(//*7837xzc2---34rlxXP%$”."]);