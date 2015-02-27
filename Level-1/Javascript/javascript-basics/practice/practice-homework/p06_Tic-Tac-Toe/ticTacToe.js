var even = true;
var click1 = true;
var click2 = true;
var click3 = true;
var click4 = true;
var click5 = true;
var click6 = true;
var click7 = true;
var click8 = true;
var click9 = true;
var field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
var leftScore = 0;
var rightScore = 0;

var div1 = document.getElementById("div1");
div1.onclick = function () {
    if (click1) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[0] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[0] = 'x';
        }
        click1 = false;
        check();
    }
}

var div2 = document.getElementById("div2");
div2.onclick = function () {
    if (click2) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[1] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[1] = 'x';
        }
        click2 = false;
        check();
    }
}

var div3 = document.getElementById("div3");
div3.onclick = function () {
    if (click3) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[2] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[2] = 'x';
        }
        click3 = false;
        check();
    }
}

var div4 = document.getElementById("div4");
div4.onclick = function () {
    if (click4) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[3] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[3] = 'x';
        }
        click4 = false;
        check();
    }
}

var div5 = document.getElementById("div5");
div5.onclick = function () {
    if (click5) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[4] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[4] = 'x';
        }
        click5 = false;
        check();
    }
}

var div6 = document.getElementById("div6");
div6.onclick = function () {
    if (click6) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[5] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[5] = 'x';
        }
        click6 = false;
        check();
    }
}

var div7 = document.getElementById("div7");
div7.onclick = function () {
    if (click7) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[6] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[6] = 'x';
        }
        click7 = false;
        check();
    }
}

var div8 = document.getElementById("div8");
div8.onclick = function () {
    if (click8) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[7] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[7] = 'x';
        }
        click8 = false;
        check();
    }
}

var div9 = document.getElementById("div9");
div9.onclick = function () {
    if (click9) {
        if (even) {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/circle.PNG')";
            even = !even;
            field[8] = 'o';
        } else {
            this.style.backgroundSize = "70px";
            this.style.backgroundImage = "url('images/ex.PNG')";
            even = !even;
            field[8] = 'x';
        }
        click9 = false;
        check();
    }
}

function restGameBackground() {
    click1 = false;
    click2 = false;
    click3 = false;
    click4 = false;
    click5 = false;
    click6 = false;
    click7 = false;
    click8 = false;
    click9 = false;
    
    // loading external CSS VERY USEFULL
    var $ = document; // shortcut
    var cssId = 'myCss';  // you could encode the css path itself to generate id..
    if (!$.getElementById(cssId)) {
        var head = $.getElementsByTagName('head')[0];
        var link = $.createElement('link');
        link.id = cssId;
        link.rel = 'stylesheet';
        link.type = 'text/css';
        link.href = 'styles/animation.css';
        link.media = 'all';
        head.appendChild(link);
    }

    setTimeout(function () {
        document.getElementById("result").innerText = "";
        div1.style.backgroundImage = "none";
        div2.style.backgroundImage = "none";
        div3.style.backgroundImage = "none";
        div4.style.backgroundImage = "none";
        div5.style.backgroundImage = "none";
        div6.style.backgroundImage = "none";
        div7.style.backgroundImage = "none";
        div8.style.backgroundImage = "none";
        div9.style.backgroundImage = "none";
        click1 = true;
        click2 = true;
        click3 = true;
        click4 = true;
        click5 = true;
        click6 = true;
        click7 = true;
        click8 = true;
        click9 = true;
        even = true;
    }, 1300);
}

function check() {
    if (field[0] == 'x' && field[1] == 'x' && field[2] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";      
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    }else if (field[3] == 'x' && field[4] == 'x' && field[5] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";              
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[6] == 'x' && field[7] == 'x' && field[8] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                     
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[0] == 'x' && field[3] == 'x' && field[6] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                                  
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[1] == 'x' && field[4] == 'x' && field[7] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                                 
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[2] == 'x' && field[5] == 'x' && field[8] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                                 
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[0] == 'x' && field[4] == 'x' && field[8] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                                     
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[2] == 'x' && field[4] == 'x' && field[6] == 'x') {
        rightScore++;
        document.getElementById("rr").style.cssFloat = "right";                                        
        document.getElementById("rightScore").innerText = rightScore;
        document.getElementById("result").innerText = "X win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    }else if (field[0] == 'o' && field[1] == 'o' && field[2] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                                       
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[3] == 'o' && field[4] == 'o' && field[5] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                   
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[6] == 'o' && field[7] == 'o' && field[8] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                         
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[0] == 'o' && field[3] == 'o' && field[6] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                         
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[1] == 'o' && field[4] == 'o' && field[7] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                                 
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[2] == 'o' && field[5] == 'o' && field[8] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                                    
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[0] == 'o' && field[4] == 'o' && field[8] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";                                                 
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[2] == 'o' && field[4] == 'o' && field[6] == 'o') {
        leftScore++;
        document.getElementById("rr").style.cssFloat = "left";     
        document.getElementById("leftScore").innerText = leftScore;
        document.getElementById("result").innerText = "O win";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    } else if (field[0] != "0" && field[1] != "0" && field[2] != "0" && field[3] != "0" && field[0] != "4" && field[5] != "0" && field[6] != "0" && field[7] != "0" && field[8] != "0") {
        var rand = Math.floor(Math.random() * 2) + 1;
        if (rand == 1) {
            document.getElementById("rr").style.cssFloat = "left";
        } else {
            document.getElementById("rr").style.cssFloat = "right";  
        }
        document.getElementById("result").innerText = "Draw";
        field = ['0', '0', '0', '0', '0', '0', '0', '0', '0'];
        restGameBackground();
    }
}


//////////////// if YOU WANT try DELETE ELEMENTS ///////////////
//document.getElementById("result").remove();

//var div = document.createElement("div");
//div.id = "result";
//document.getElementById("").appendChild(div);
//Element.prototype.remove = function () {
//    this.parentElement.removeChild(this);
//}
//NodeList.prototype.remove = HTMLCollection.prototype.remove = function () {
//    for (var i = 0, len = this.length; i < len; i++) {
//        if (this[i] && this[i].parentElement) {
//            this[i].parentElement.removeChild(this[i]);
//        }
//    }
//}