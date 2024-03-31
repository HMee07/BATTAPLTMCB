const form = document.querySelector('form');

form.addEventListener('submit', (event) => {
  event.preventDefault();

  // Xử lý đăng nhập (kiểm tra thông tin đăng nhập)

  // Chuyển hướng đến trang chủ
  window.location.href = "home.html";
});

const password = document.getElementById("password");
const eye = document.getElementById("eye");

eye.addEventListener("click", function() {
  if (password.type === "password") {
    password.type = "text";
    eye.classList.add("fa-eye-slash");
  } else {
    password.type = "password";
    eye.classList.remove("fa-eye-slash");
  }
});
