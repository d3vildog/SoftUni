document.getElementById("butt").onclick = function () {
    var input = document.getElementById("txt").value;
    var expression = input.match(/[0-9-+/*]/g).join("");
    document.getElementById("result").innerText = eval(expression);
};
