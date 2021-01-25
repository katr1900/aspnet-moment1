var buttonElement = document.getElementById("button");
if (buttonElement) {
    var button = document.createElement("button");
    button.innerHTML = "Klicka här";
    button.addEventListener("click", function() {
        window.location.href = "/razor";
    })
    buttonElement.appendChild(button);
}