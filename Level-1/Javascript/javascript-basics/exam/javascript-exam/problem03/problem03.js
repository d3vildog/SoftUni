function solve(input) {
    var output = {};
    var outputStr = '';

    for (var j = 0; j < input.length; j++) {
        var currString = input[j].replace(/%20|\+/g, ' ');
        currString = currString.replace(/.+\?/g, '');
        var fieldsValues = currString.trim().split(/&/g);
        
        for (var i = 0; i < fieldsValues.length; i++) {
            var pair = fieldsValues[i].split(/=/g);
            var currKey = pair[0].trim().replace(/\s+/g, ' ');
            var currValue = pair[1].trim().replace(/\s+/g, ' ');
            
            if (!(currKey in output)) {
                output[currKey] = [];
            }
            
            output[currKey].push(currValue);
        }
        
        for (var key in output) {
            outputStr += key + '=[' + output[key].join(', ') + ']';
        }

        console.log(outputStr);
        outputStr = "";
        output = {};
    }
}

solve([
    'foo=%20foo&value=+val&foo+=5+%20+203', 
    'foo=poo%20&value=valley&dog=wow+', 
    'url=https://softuni.bg/trainings/coursesinstances/details/1070', 
    'https://softuni.bg/trainings?trainer=nakov&course=oop&course=php' 
]);

//solve(['field=value1&field=value2&field=value3', 'http://example.com/over/there?name=ferret']);
//solve(['login=student&password=student']);
