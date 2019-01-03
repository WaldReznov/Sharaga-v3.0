function validate(){
    var userName=document.getElementById("userName");
    var god=document.getElementById("god");
    var adress=document.getElementById("adress");
    var tel=document.getElementById("tel");
    var cm=document.getElementById("cm");
    var email=document.getElementById("email");
    if (!userName.value){
        userName.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    if (!god.value){
        god.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    if (!adress.value){
        adress.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    if (!tel.value){
        tel.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    if (!cm.value){
        cm.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    if (!email.value){
        email.style.border = "2px solid red";
        alert("Введите значение");
        return false;
    }
    return true;
}