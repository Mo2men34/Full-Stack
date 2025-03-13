let mix1 = [1, 2, 3, "E", 4, "l", "z", "e", "r", 5, "o"];
let mix2 = mix1.reduce((acc,i)=>(typeof i === "string") ? acc + i:acc,"")
console.log(mix2)