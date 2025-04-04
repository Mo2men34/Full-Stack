let chars = ["A", "B", "C", "D", "E", 10, 15, 6];

let numbers = [];
let letters = [];
chars.forEach(item => (typeof item === "number" ? numbers.push(item) : letters.push(item)));

let result = [...letters.slice(0, numbers.length), ...letters];

console.log(result);