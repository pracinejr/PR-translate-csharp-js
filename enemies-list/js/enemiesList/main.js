// Put your code here
const enemies = [
    {
        id: 1,
        FirstName: "Joshua",
        LastName: "Flowers",
        Offenses: [
            "Being a jerk to me in elementary school",
            "Not being nice to me in elementary school"
        ],
        IsReallyHated: true
    },
    {
        id: 2,
        FirstName: "Darth",
        LastName: "Vader",
        Offenses: [
            "Cut off Luke's hand",
            "Murdered all those kids",
            "Unkind management practices"
        ],
        IsReallyHated: false
    },
    {
        id: 3,
        FirstName: "Betty",
        LastName: "Rudelady",
        Offenses: [
            "Phone calls in the theater",
            "Phone calls on the bus",
            "Phone calls in line at the grocery store",
            "Poor conversationalist"
        ],
        IsReallyHated: true
    },
    {
        id: 4,
        FirstName: "Leon",
        LastName: "Peck",
        Offenses: [
            "Keeps giving me a hotplate"
        ],
        IsReallyHated: false
    },
]

for (let enemy of enemies) {
    if (enemy.IsReallyHated === true) {
        console.log(`${enemy.FirstName} ${enemy.LastName} Really, really dislike!`)
    } else {
        console.log(`${enemy.FirstName} ${enemy.LastName}`)        
    }
}