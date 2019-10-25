var btn = document.getElementById("btn_submit");
btn.addEventListener("click", afgift);
//var input = document.getElementById("car_price");
var input = document.getElementById("car_price");
console.log("input from user:" + input.value);
var priceInput = input.value;
console.log("input converted to number:" + priceInput);
function afgift() {
    var input = document.getElementById("car_price");
    console.log("input from user:" + input.value);
    var priceInput = input.value;
    console.log("input from user:" + input.value);
    var UserNumber = +priceInput;
    var isInputANumber = !isNaN(UserNumber);
    console.log("bool: " + isInputANumber);
    var e = (document.getElementById("car_type"));
    var sel = e.selectedIndex;
    var opt = e.options[sel];
    var carPrice = +priceInput;
    if (isInputANumber) {
        console.log("drp: " + sel);
        if (sel == 0) {
            AfgiftPerCar(carPrice);
        }
        if (sel == 1) {
            AfgiftElCar(carPrice);
        }
    }
    else {
        document.getElementById("feedback").innerHTML = "den indtastet pris er ikke brugbar.";
        console.log("den indtastet pris er ikke brugbar.");
    }
}
function AfgiftElCar(user_input) {
    var size = 0.85;
    var bigPrice = false;
    if (user_input > 200000) {
        size = 1.50;
        bigPrice = true;
    }
    else {
        size = 0.85;
        bigPrice = false;
    }
    var outcome = (user_input * size) - 130000;
    document.getElementById("feedback").innerHTML = "bilens fulde afgift er: " + outcome + " kr";
    console.log("bil afgift er: " + outcome + " kr");
}
function AfgiftPerCar(user_input) {
    var size = 0.85;
    var bigPrice = false;
    if (user_input > 200000) {
        size = 1.50;
        bigPrice = true;
    }
    else {
        size = 0.85;
        bigPrice = false;
    }
    var outcome = (user_input * size);
    document.getElementById("feedback").innerHTML = "bilens fulde afgift er: " + outcome + " kr";
    console.log("bil afgift er: " + outcome + " kr");
}
