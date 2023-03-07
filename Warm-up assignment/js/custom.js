// Sidebar
// const hamburger = document.getElementById(hamburger);
let menu = document.querySelector(".menu");
let menuIcon = document.querySelector(".menuIcon");
let closeIcon = document.querySelector(".closeIcon");

function openCloseSidebar() {
  if (menu.classList.contains("show-menu")) {
    // now close the sidebar
    menu.classList.add("hide-menu");
    menu.classList.remove("show-menu");
    closeIcon.style.display = "none";
    menuIcon.style.display = "block";
  } else {
    // open the sidebar
    menu.classList.remove("hide-menu");
    menu.classList.add("show-menu");
    menuIcon.style.display = "none";
    closeIcon.style.display = "block";
  }
}

// Upload Button
const actualBtn = document.getElementById("getFile");

const fileChosen = document.getElementById("file-chosen");

actualBtn.addEventListener("change", function () {
  fileChosen.innerText = this.files[0].name;
});