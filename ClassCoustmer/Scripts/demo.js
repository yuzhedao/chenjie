var li = document.querySelectorAll(".ul-list li");
// window.alert("welcome mysittes !");
console.log(li);
var prev = document.getElementById('prev');
var next = document.getElementById('next');
var i = 0;

next.onclick = function(){
 Move();
} 

prev.onclick = function(){
    i--;
   if (i == 0){
        i=li.length;
    }
  console.log(li);
    for(var j = i;j < li.length;j++){
        li[j].style.opacity = 0;
    }
    li[i].style.opacity = 1;
} 
console.log(li);
setInterval(function(){
    Move();
},5000);
function Move(){
    i++;
    if (i == li.length-2){
         i=0;
     }
     for(var j = 0;j <li.length;j++){
        li[j].style.opacity = 0;
    }
    li[i].style.opacity = 1;
}