function solve(numbers) {
    var start = numbers[0];
    var end = numbers[1];
    console.log("<ul>");

    for (var i = start; i <= end; i++) {
        if (i < 1000) {
            console.log("<li><span class='num'>" + i + "</span></li>");
        } else {
            check(i);
        }
    }

    function check() {
        var strI = "" + i;

        for (var j = 1; j < strI.length; j++) {
            var currCouple = strI[j - 1] + "" + strI[j];
            
            for (var k = j + 1; k < strI.length; k++) {
                var nextCouple = strI[k] + "" + strI[k + 1];
                
                if (currCouple == nextCouple) {
                    console.log("<li><span class='rakiya'>" + strI + '</span><a href="view.php?id=' + strI + '">View</a></li>');
                    return;
                }
            }
        }

        console.log("<li><span class='num'>" + strI + "</span></li>");
    }

    console.log("</ul>");
}

//solve([5, 8]);
//solve([11210, 11215]);
solve([999999910, 1000000000]);