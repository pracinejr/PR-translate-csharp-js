const spells = 
    [
    {
        id: 1,
        name: "Turn enemy into a newt",
        isEvil: true,
        energyReqired: 5.1
    },
    {
        id: 2,
        name: "Conjure some gold for a local charity",
        isEvil: false,
        energyReqired: 2.99
    },
    {
        id: 3,
        name: "Give a deaf person the ability to heal",
        isEvil: false,
        energyReqired: 12.2
    },
    {
        id: 4,
        name: "Make yourself emperor of the universe",
        isEvil: true,
        energyReqired: 100.0
    },
    {
        id: 5,
        name: "Convince your relatives your political views are correct",
        isEvil: false,
        energyReqired: 2921.5
    }
];

console.log("Do you believe in magic?");
console.log("------------------------");

console.log("Good Book");
const goodBook = spells.map((spell) => {
    if (spell.isEvil === false) {
        console.log(`${spell.name}\nEnergy Required: ${spell.energyReqired}`)
    }
})

console.log("");
console.log("Evil Book");
const evilBook = spells.map((spell) => {
    if (spell.isEvil === true) {
        console.log(spell.name)
    }
})