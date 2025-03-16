let input = document.querySelector('.inp');
let result = document.querySelector('.result');

function calc()
{
    let dollar = input.value;
    let pound = (dollar * 15.6).toFixed(2);
    result.innerText = `${dollar} USD Dollar = ${pound} Egyptian Pound`;
}

input.addEventListener("input", calc);