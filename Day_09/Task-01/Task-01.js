let myFriends = [
{ title: "Osama", age: 39, available: true, skills: ["HTML", "CSS"] },
{ title: "Ahmed", age: 25, available: false, skills: ["Python", "Django"] },
{ title: "Sayed", age: 33, available: true, skills: ["PHP", "Laravel"] },
];

let input = document.getElementById("number");
let btn = document.getElementById("btn");

btn.addEventListener("click", () => {
    let chosen = parseInt(input.value);
    if (chosen === 1)
    {
        let { title, age, available, skills:[,last] } = myFriends[0];
        console.log(`${title} \n ${age} \n ${available ? "Available" : "Not Available"} \n ${last}`);
    }
    else if (chosen === 2)
    {
        let { title, age, available, skills:[,last] } = myFriends[1];
        console.log(`${title} \n ${age} \n ${available ? "Available" : "Not Available"} \n ${last}`);
    }
    else if (chosen === 3)
    {
        let { title, age, available, skills:[,last] } = myFriends[2];
        console.log(`${title} \n ${age} \n ${available ? "Available" : "Not Available"} \n ${last}`);
    }
})