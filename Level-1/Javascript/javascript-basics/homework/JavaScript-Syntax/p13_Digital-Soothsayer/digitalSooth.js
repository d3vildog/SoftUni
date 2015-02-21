function soothsayer() {
    function random(){
        return  Math.floor((Math.random() * 4) + 1)
    }
    console.log("You will work %s years on %s.\nYou will live in %s and drive %s.",arguments[0][0][random()]
        ,arguments[0][1][random()],arguments[0][2][random()],arguments[0][3][random()]);
}
soothsayer([[3, 5, 2, 7, 9],["Java","Python", "C#","JavaScript","Ruby"],["Silicon Valley", "London", "Las Vegas",
    "Paris", "Sofia"], ["BMW", "Audi", "Lada","Skoda", "Opel"]]);