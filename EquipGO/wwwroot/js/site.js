document.addEventListener("DOMContentLoaded", function () {
    const menuToggle = document.getElementById("menu-toggle");
    const navList = document.getElementById("nav-list");

    if (menuToggle) {
        menuToggle.addEventListener("click", function () {
            navList.classList.toggle("active");
        });
    }
});

