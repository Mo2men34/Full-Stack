let theNumber = 100020003000;

let uniqueSet = new Set(theNumber.toString());
uniqueSet.delete('0');
console.log([...uniqueSet].join(''));
