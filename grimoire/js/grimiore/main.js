// Put your code here

console.log("Do you believe in magic?")
console.log("------------------------")

const GetAllSpells = () => {
    let allSpells = [
        {
            Name: "Turn enemy into a newt",
            IsEvil: true,
            EnergyRequired: 5.1
        },
        {
            Name: "Conjure some gold for a local charity",
            IsEvil: false,
            EnergyRequired: 2.99
        },
        {
            Name: "Give a deaf person the ability to heal",
            IsEvil: false,
            EnergyRequired: 12.2
        },
        {
            Name: "Make yourself emperor of the universe",
            IsEvil: true,
            EnergyRequired: 100.0
        },
        {
            Name: "Convince your relatives your political views are correct",
            IsEvil: false,
            EnergyRequired: 2921.5
        }
    ]
    return allSpells
}

// let allSpells = GetAllSpells();
// let goodBook = MakeGoodSpellBook(allSpells);
// let evilBook = MakeEvilSpellBook(allSpells);

//loops through to determine good or evil for each spell
// for (let singleSpell of allSpells) {
//     if (singleSpell.IsEvil === true){
//         console.log("^Evil Spell^:", singleSpell.Name)
//     } else {
//         console.log("*Good Spell*:", singleSpell.Name)
//     }
// }

console.log("")

function MakeEvilSpellBook(allSpells) {
    const evilBook = {}
    evilBook.Title =  "^Evil Book^";
    evilBook.Spells = allSpells.filter(spell => spell.IsEvil);

    return evilBook;
}

function MakeGoodSpellBook(allSpells) {
    const goodBook = {}
    goodBook.Title =  "*Good Book*";
    goodBook.Spells = allSpells.filter(spell => !spell.IsEvil);
    
    return goodBook;
}

const allSpells = GetAllSpells();
const goodBook = MakeGoodSpellBook(allSpells);
const evilBook = MakeEvilSpellBook(allSpells);

function DisplaySpellBook(book) {
    console.log(book.Title);
    for (let singleSpell of book.Spells) {
        console.log(`${singleSpell.Name}`)
    }
}

//Call the functions below
DisplaySpellBook(goodBook);
console.log("");
DisplaySpellBook(evilBook)