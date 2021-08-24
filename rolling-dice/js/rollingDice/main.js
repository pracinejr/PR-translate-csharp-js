const dieToString = (roll) => {

    let dieString = ""

if ( roll === 1){
    dieString = "one";
}
else if ( roll === 2){
    dieString = "two";
}
else if ( roll === 3){
    dieString = "three";
}
else if ( roll === 4){
    dieString = "four";
}
else if ( roll === 5){
    dieString = "five";
}
else{
    dieString = "six";
}

return dieString;

}

const roll = () => {
    const dieValue = Math.ceil(Math.random() * 6);
    const die = dieValue;

    return die;
}

const Value = (die) => {
    const value = dieToString(die);
    return value;
}


console.log("Let's roll some dice, baby!");
console.log("---------------------------");

for (let i = 0; i < 10; i++) {
    die1num = roll();
    die2num = roll();

    die1 = Value(die1num);
    die2 = Value(die2num);

    let message = `${die1} + ${die2} = ${die1num + die2num}`;
    if (die1 === die2) {
        message += " DOUBLES!";
    }

    console.log(message)
}