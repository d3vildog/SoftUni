function solve(arr) {
    var bill = arr[0];
    var mood = arr[1];
    
    if (mood === "happy") {
        bill = bill / 10;
    } else if (mood == "married") {
        bill = bill * 0.0005;
    } else if (mood == "drunk") {
        bill = Math.pow(bill * 0.15, getFirstNumb((bill * 0.15)));
    } else {
        bill = bill * 0.05;
    }
    
    function getFirstNumb(numb) {
        var strNumb = "" + numb;
        return parseInt(strNumb[0]);
    }
    
    return bill.toFixed(2);
}