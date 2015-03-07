"use strict";

function printArgsInfo() {
    for (var i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + " (" + typeof (arguments[i]) + ")");
    }
}

printArgsInfo.call(null);
printArgsInfo.call(null, "str", true, 1.5);

printArgsInfo.apply(null);
printArgsInfo.apply(null, ["str", true, 1.5]);
