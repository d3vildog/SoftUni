'use strict';

function Person(firstName, lastName) {
    var fname = firstName;
    var lname = lastName;
    var name = firstName + " " + lastName;
    
    return {
        firstName: fname,
        lastName: lname,
        name: name
    }
}

var peter = new Person("Peter", "Jackson");
console.log(peter.name);
console.log(peter.firstName);
console.log(peter.lastName);


var izi = new Person("Izi", "Menson");
console.log(izi.name);
console.log(izi.firstName);
console.log(izi.lastName);
