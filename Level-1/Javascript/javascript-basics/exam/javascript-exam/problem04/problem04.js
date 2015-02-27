function solve(input) {
    var students = [];
    var newStudents = [];
    var trainers = [];
    var criteria = input[0].split(/\^/)[0];
    
    for (var i = 1; i < input.length; i++) {
        input[i] = input[i].toLowerCase();
        if (JSON.parse(input[i]).role == "trainer") {
            trainers.push(JSON.parse(input[i]));
        } else {
            students.push(JSON.parse(input[i]));
        }
    }

    for (var j = 0; j < students.length; j++) {
        var currStudent = students[j];
        var averageGrade = sumGrades(students[j].grades);

        newStudents[j] = {id: currStudent.id, firstname: currStudent.firstname.toLowerCase(), lastname: currStudent.lastname.toLowerCase(), averageGrade: averageGrade.toFixed(2), certificate: currStudent.certificate};
    }

    for (var k = 0; k < trainers.length; k++) {
        delete trainers[k].town;
        delete trainers[k].role;
    }
    
    function sumGrades(arr) {
        var sum = 0;
        for (var k = 0; k < arr.length; k++) {
            sum += parseFloat(arr[k]);
        } 

        return sum / arr.length;
    }

    function compareStudents(a, b) {
        if (a.firstname < b.firstname)
            return -1;
        if (a.firstname > b.firstname)
            return 1;
        if (a.firstname == b.firstname) {
            if (a.lastname < b.lastname)
                return -1;
            if (a.lastname > b.lastname)
                return 1;
        }
    }
    
    function compareStudentsLevel(a, b) {
        if (Number(a.level) - Number(b.level) == 0) {
            if (Number(a.id) < Number(b.id))
                return -1;
            if (Number(a.id) > Number(b.id))
                return 1;
        }

        return Math.abs(Number(a.level) - Number(b.level));
    }

    function compareTrainers(a, b) {
        if (a.courses.length < b.courses.length)
            return -1;
        if (a.courses.length > b.courses.length)
            return 1;
        if (a.courses.length == b.courses.length) {
            if (Number(a.lecturesPerDay) < Number(b.lecturesPerDay))
                return -1;
            if (Number(a.lecturesPerDay) > Number(b.lecturesPerDay))
                return 1;
        }
    }

    if (criteria === "level") {
        newStudents.sort(compareStudentsLevel);
    } else {
        newStudents.sort(compareStudents);
    }
    trainers.sort(compareTrainers);

    var output = { students : newStudents, trainers : trainers };
    console.log(JSON.stringify(output));
}
//solve([
//    'level^courses',
//    '{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
//    '{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
//    '{"id":2,"firstname":"Bobi","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
//    '{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
//    '{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps","Java"],"lecturesPerDay":2}'
//]);

solve([
    'name^courses',
    '{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
    '{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
    '{"id":2,"firstname":"Angel","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
    '{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
    '{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps"],"lecturesPerDay":2}'
]);