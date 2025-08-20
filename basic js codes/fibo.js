let n = parseInt(prompt("Enter number of terms:"));
let a = 0, b = 1, sum = 0;

for (let i = 0; i < n; i++) {
    sum += a;
    let temp = a + b;
    a = b;
    b = temp;
}

console.log("Sum of Fibonacci series up to " + n + " terms is: " + sum);
