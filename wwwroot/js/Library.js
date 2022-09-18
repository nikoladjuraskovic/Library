"use strict";


/*Primena na Login.cshtml stranicu u Areas->Identity*/

/*Kod bi trebalo da salje poruke Hub-u*/

var connection = new signalR.HubConnectionBuilder().withUrl("/LibraryHub").build();

//Disable the send button until connection is established.
document.getElementById("login-submit").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message}`;
});

connection.start().then(function () {
    document.getElementById("login-submit").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("login-submit").addEventListener("click", function (event) {
    var user = document.getElementById("loginEmail").value;
    var message = document.getElementById("loginPassword").value;

    /*
     * The invoke method returns a JavaScript Promise.
     * The Promise is resolved with the return value (if any) when the method on the server returns.
     * If the method on the server throws an error,
     * the Promise is rejected with the error message.
     */
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});