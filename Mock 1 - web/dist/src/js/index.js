function greeter(person) {
    return "Hello, " + person.firstName + " " + person.lastName;
}
var user = { firstName: "John", lastName: "Doe" };
var element = document.getElementById("content");
element.innerHTML = greeter(user);
