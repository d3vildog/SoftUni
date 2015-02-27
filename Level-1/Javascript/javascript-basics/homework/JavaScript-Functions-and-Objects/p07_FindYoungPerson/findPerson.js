function findYoungestPerson(persons) {
    var youngestMan = [Number.MAX_VALUE, ""];
    

    for (var i = 0; i < persons.length; i++) {
        if (persons[i].age < youngestMan[0]) {
            youngestMan[0] = persons[i].age;
            youngestMan[1] = persons[i].firstname + " " + persons[i].lastname;
        }
    }

    console.log('The youngest person is ' + youngestMan[1]);
}

var persons = [
    { firstname: 'George', lastname: 'Kolev', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Baba', lastname: 'Ginka', age: 40 }
];

findYoungestPerson(persons);