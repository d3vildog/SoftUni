"use strict";

function testContext() {
    console.log(this);
}

testContext();

function printSomething() {
    var a = 7;
    console.log(a);
    testContext();
}

var bb = new testContext();
