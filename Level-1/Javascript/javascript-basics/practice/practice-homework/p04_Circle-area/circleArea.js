function calcCircleArea(r) {
    var circleArea = Math.PI * Math.pow(r, 2);

    var x = document.createElement("p");                        
    var t = document.createTextNode("r = " + r + "; area = " + circleArea);    
    x.appendChild(t);                                           
    document.body.appendChild(x);    
}

calcCircleArea(7);
calcCircleArea(1.5);
calcCircleArea(20);