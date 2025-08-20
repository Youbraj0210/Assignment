let input = prompt("Enter numbers separated by space:");
let numbers = input.split(" ").map(Number);

let evenCount = 0, oddCount = 0, zeroCount = 0;

for (let num of numbers) {
    if (num === 0) {
        zeroCount++;
    } else if (num % 2 === 0) {
        evenCount++;
    } else {
        oddCount++;
    }
}

console.log("Even numbers: " + evenCount);
console.log("Odd numbers: " + oddCount);
console.log("Zeros: " + zeroCount);
