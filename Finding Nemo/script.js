const totalBubbles = 10;
let attempts = 0;
let maxAttempts = 5;
let nemoIndex = -1;
let gameOver = false;

const gameGrid = document.getElementById('gameGrid');
const messageEl = document.getElementById('message');
const attemptsEl = document.getElementById('attempts');

function initGame() {
  gameGrid.innerHTML = '';
  attempts = 0;
  gameOver = false;
  nemoIndex = Math.floor(Math.random() * totalBubbles);
  messageEl.textContent = '';
  attemptsEl.textContent = `Attempts: ${attempts} / ${maxAttempts}`;

  for (let i = 0; i < totalBubbles; i++) {
    const bubble = document.createElement('div');
    bubble.classList.add('bubble');
    bubble.setAttribute('data-index', i);

    const img = document.createElement('img');
    bubble.appendChild(img);

    bubble.addEventListener('click', () => handleClick(bubble, i));
    gameGrid.appendChild(bubble);
  }
}

function handleClick(bubble, index) {
  if (gameOver || bubble.classList.contains('clicked')) return;

  attempts++;
  attemptsEl.textContent = `Attempts: ${attempts} / ${maxAttempts}`;
  bubble.classList.add('clicked');

  const img = bubble.querySelector('img');

  if (index === nemoIndex) {
    img.src = 'Nemo.jpg';
    messageEl.textContent = '🎉 Congratulations, You Found Nemo!';
    gameOver = true;
    disableRemaining();
  } else {
    img.src = 'x.png';
    img.style.objectFit = 'contain';
    if (attempts >= maxAttempts) {
      messageEl.textContent = ` Out of attempts! Nemo was at bubble ${nemoIndex + 1}`;
      revealNemo();
      gameOver = true;
    }
  }
}

function revealNemo() {
  const bubbles = document.querySelectorAll('.bubble');
  const nemoBubble = bubbles[nemoIndex];
  nemoBubble.querySelector('img').src = 'Nemo.jpg';
  nemoBubble.classList.add('clicked');
}

function disableRemaining() {
  document.querySelectorAll('.bubble').forEach(b => b.classList.add('clicked'));
}

function restartGame() {
  initGame();
}

window.onload = initGame;
