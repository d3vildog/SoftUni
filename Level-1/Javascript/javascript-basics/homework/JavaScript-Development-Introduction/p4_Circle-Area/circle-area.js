﻿function calcCircleArea() {
    var input = (document.getElementById("input-field"));
    input = Number(input.value);
    if (isNaN(input)) {
        alert("Invalid input");
    }
    else {
        var r = input;
        var area = Math.pow(r, 2) * Math.PI;
        document.getElementById("answer").innerHTML = area;
        console.log(r + " " + area);
    }
}