function solve(input) {
    var biggestFan = new Date(1973, 04, 25);
    var fanChanged = false;
    var biggestHater = new Date(1973, 04, 24);
    var haterChanged = false;
    var excludeBefore = new Date(1900, 00, 02);
    var excludeAfter = new Date(2015, 00, 01);

    for (var i = 0; i < input.length; i++) {
        var getDate = input[i].split(/\./g);
        var day = getDate[0];
        var month = getDate[1] - 1;
        var year = getDate[2];
        var currDate = new Date(year, month, day);

        if (currDate <  excludeBefore || currDate > excludeAfter) {
            continue;
        }

        if (currDate > biggestFan) {
            biggestFan = currDate;
            fanChanged = true;
        }else if (currDate < biggestHater) {
            biggestHater = currDate;
            haterChanged = true;
        }
    }

    if (fanChanged && haterChanged) {
        console.log('The biggest fan of ewoks was born on ' + biggestFan.toDateString());
        console.log('The biggest hater of ewoks was born on ' + biggestHater.toDateString());
    }else if (fanChanged) {
        console.log('The biggest fan of ewoks was born on ' + biggestFan.toDateString());
    }else if (haterChanged) {
        console.log('The biggest hater of ewoks was born on ' + biggestHater.toDateString());
    } else {
        console.log("No result");
    }
}

solve([
    '01.01.1900',
    '01.02.1900',
    '01.03.1900',
    '01.04.1900',
    '01.05.1900',
    '01.06.1900',
    '31.12.2014',
    '15.11.2456'
]);

//solve([
//    '22.03.2014',
//    '17.05.1933',
//    '10.10.1954'
//]);
