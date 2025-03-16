let image = document.querySelectorAll('img')

for(let i=0; i<image.length; i++)
{
    if(image[i].hasAttribute('alt'))
        image[i].alt = 'Old'
    else
        image[i].alt = 'Elzero New'
};