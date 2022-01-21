// Put your code here.

console.log("Let's roll some dice, baby!")
console.log("---------------------------")

//Generate random number using this provided function:
function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

//creates a function to "roll" die, generates a random number between 1 and 6.
function Roll()  {
    //die equal to random number generated by getRandomInt, also set a min number then a max number
    let die= getRandomInt(1,6);
    return die;
}

function ToString(number) {
    // just assigning dieString so we can reassign it later, can be an empty string "" and it should still work.
    let dieString = "Unknown";
    //switch or use and if/else, in a switch, break just keeps it from looping. You can use the switch from the C# code and it works in JS. This is a big conditional.
    switch (number) {
        case 1:
            dieString = "\u2680"; // These \uXXXX values are fancy unicode characters
            break;
        case 2:
            dieString = "\u2681";
            break;
        case 3:
            dieString = "\u2682";
            break;
        case 4:
            dieString = "\u2683";
            break;
        case 5:
            dieString = "\u2684";
            break;
        case 6:
            dieString = "\u2685";
            break;
    }

    return dieString;

}

for (let i = 0; i < 10; i++) {
        const die1 = Roll();
        const die2 = Roll();
//take the die1 or die2 and run it through the ToString() function then prints out the die icon, without the ToString(), it would just show the number. The second half is adding the amounts for die1 & die2 together
        let message = `${ToString(die1)} + ${ToString(die2)} == ${die1 + die2}`;

        if (die1 == die2) {
            message += " DOUBLES!";
        }

        console.log(message)
    }




//--------------------------------------------------------------
// Put your code here -- simplified code another group figured out. Reference how this is stream lined compared to code above:
// console.log("Let's roll some dice, baby!")
// console.log("---------------------------")

// for (let i = 0; i < 10; i++) {
//     let die1 = Math.floor(Math.random() * 6) +1
//     let die2 = Math.floor(Math.random() * 6) +1

//     if (die1 === die2) {
//         console.log(`${die1} + ${die2} = (${die1 + die2}) Doubles!`)
//     } else {
//         console.log(`${die1} + ${die2} = (${die1 + die2})`)
//     }
//   }
