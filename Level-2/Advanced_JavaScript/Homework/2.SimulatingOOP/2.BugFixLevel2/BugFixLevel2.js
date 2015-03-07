function Person(fname, lname) {
    var firstName = fname;
    var lastName = lname;
    var fullName = firstName + ' ' + lastName;

    var setFirstName = function(name) {
        firstName = name;
        fullName = firstName + ' ' + lastName;
    }

    var setLastName = function(name) {
        lastName = name;
        fullName = firstName + ' ' + lastName;
    }

    var setFullName = function(name) {
        var arr = name.trim().split(/\s+/);
        firstName = arr[0];
        lastName = arr[1];
        fullName = firstName + ' ' + lastName;
    }
    
    setFirstName.toString = function () { return firstName + ""; }
    setLastName.toString = function () { return lastName + ""; }
    setFullName.toString = function () { return fullName + ""; }

    return {
        firstName: setFirstName,
        lastName: setLastName,
        fullName: setFullName
    }
}

var person = new Person("Peter", "Jackson");
// Getting values
console.log(person.firstName);
console.log(person.lastName);
console.log(person.fullName);
// Changing values
person.firstName = "Michael";
console.log(person.firstName);
//console.log(person.fullName);
//person.lastName = "Williams";
//console.log(person.lastName);
//console.log(person.fullName);
