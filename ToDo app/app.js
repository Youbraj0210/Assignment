const addBtn = document.getElementById("addBtn");
const todoInput = document.getElementById("todoInput");
const todoList = document.getElementById("todoList");

addBtn.addEventListener("click", () => {
    const task = todoInput.value.trim();
    if (task !== "") {
        const li = document.createElement("li");
        li.className = "list-group-item d-flex justify-content-between align-items-center";

        li.innerHTML = `
          <span>${task}</span>
          <button class="btn btn-sm btn-outline-danger delete-btn">
            <i class="bi bi-trash"></i>
          </button>
        `;

        li.querySelector(".delete-btn").addEventListener("click", () => {
            li.remove();
        });

        todoList.appendChild(li);
        todoInput.value = "";
    }
});

todoInput.addEventListener("keypress", (e) => {
    if (e.key === "Enter") {
        addBtn.click();
    }
});