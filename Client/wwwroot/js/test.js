
var id;
var data;
var container;

function initialize()
{
    container = document.getElementsByClassName("box");

   
    divs = []
    for(var i = 0; i < container.length; i++)
    {
        console.log(i)
        divs.push(container[i])

    }
    
    divs.forEach((item,index) => {
        item.addEventListener('click', function(){
            var t = item.querySelector("#child")
            id = t.innerText;           
        });
    });

}


function show()
{
   return id;
   
}

