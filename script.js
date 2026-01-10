/*const searchform = document.querySelector(".search-form");
const searchbtn = document.querySelector("#search-btn");

searchbtn.addEventListener("click", function() {
    searchform.classList.toggle("active");

    document.addEventListener("click", function(e) {
        if (
            !e.composedPath().includes(searchbtn) &&
            !e.composedPath().includes(searchform)
        ) {
            searchform.classList.remove("active");
        }
    });
});*/    
const cartitem = document.querySelector(".cart-items-container");
const cartbtn = document.querySelector("#cart-btn");

cartbtn.addEventListener("click", function() {
    cartitem.classList.toggle("active");

    document.addEventListener("click", function(e) {
        if (
            !e.composedPath().includes(cartbtn) &&
            !e.composedPath().includes(cartitem)
        ) {
            cartitem.classList.remove("active");
        }
    });
});