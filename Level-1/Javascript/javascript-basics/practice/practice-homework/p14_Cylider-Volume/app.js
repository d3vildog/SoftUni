function calcCylinderVol(arr) {
    var vol = (Math.PI * Math.pow(arr[0], 2) * arr[1]).toFixed(3);

    return vol;
}

console.log(calcCylinderVol([2, 4]));
console.log(calcCylinderVol([5, 8]));
console.log(calcCylinderVol([12, 3]));