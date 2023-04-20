// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




let form = document.querySelector("form");
let email_in = document.querySelector("#email");

/*
email_in.addEventListener("keyup", function(){
    validiteEmail();
});
confirm_button.addEventListener("click", function(){
    validiteEmail();

});*/
form.addEventListener("submit", function (event) {
    validiteEmail(event);

});

function validiteEmail(event) {

    let email_rgx = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    let mail_error = document.querySelector("#mail-error")

    if (email_rgx.test(email_in.value) == false) {
        event.preventDefault();  //annulla l'apertura del link di default della funziona submit
        mail_error.innerHTML = ("la mail inserita non è valida");
        console.log(mail_error);
    }

}

