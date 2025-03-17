let form = document.querySelector('form');
let inputs = form.querySelectorAll('input, select');
let num_of_elements = document.querySelector('.num-inp');
let txt_inp = document.querySelector('.txt-inp');
let btn = document.querySelector('.btn');
let elements_type = document.querySelector('.select');
let div = document.querySelector('.results');

form.style.display = 'flex';
form.style.flexDirection = 'column';
form.style.justifyContent = 'center';
form.style.alignItems = 'center';
form.style.padding = '20px';
form.style.backgroundColor = 'white';
form.style.borderRadius = '10px';
form.style.margin = 'auto';

inputs.forEach(input => {
  input.style.width = '300px'; 
  input.style.margin = '10px 0px';
  input.style.padding = '10px';
  input.style.boxSizing = 'border-box';
});

btn.style.margin = '10px 0px';
btn.style.backgroundColor = '#004186';
btn.style.color = 'white';
btn.style.borderRadius = '10px';
btn.style.fontSize = '17px';

div.style.width = '600px';
div.style.margin = '10px';
div.style.display = 'flex';
div.style.flexWrap = 'wrap';
div.style.justifyContent = 'flex-start';

form.addEventListener("submit", function (event) {
  event.preventDefault();

  div.innerHTML = "";

  const counter = parseInt(num_of_elements.value);
  const text = txt_inp.value;

  for (let i = 1; i <= counter; i++) {
    const element = document.createElement(elements_type.value);
    element.className = "box";
    element.id = `id-${i}`;
    element.title = "Element";
    element.textContent = text;

    element.style.width = "190px"; 
    element.style.height = "50px";
    element.style.display = "inline-flex"; 
    element.style.justifyContent = "center"; 
    element.style.alignItems = "center"; 
    element.style.margin = "5px";
    element.style.backgroundColor = "#007bff";
    element.style.color = "#fff";
    element.style.borderRadius = "8px";
    element.style.textAlign = "center";
    element.style.fontSize = "18px";
    element.style.fontWeight = "bold";

    div.appendChild(element);
  }
});
