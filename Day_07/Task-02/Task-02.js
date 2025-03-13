let myString1 = "EElllzzzzzzzeroo";
let myString2 = myString1.split("")
let myString3 = myString2.filter((i, index) => myString2.indexOf(i) === index);
console.log(myString3.join(""));