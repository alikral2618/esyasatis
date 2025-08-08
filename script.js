let score = 0;
let timeLeft = 30;
let gameInterval;
let timerInterval;

function startGame() {
  score = 0;
  timeLeft = 30;
  document.getElementById("score").textContent = score;
  document.getElementById("timer").textContent = timeLeft;
  document.getElementById("game-over").classList.add("hidden");

  timerInterval = setInterval(() => {
    timeLeft--;
    document.getElementById("timer").textContent = timeLeft;

    if (timeLeft <= 0) {
      endGame();
    }
  }, 1000);

  gameInterval = setInterval(createBalloon, 800);
}

function endGame() {
  clearInterval(gameInterval);
  clearInterval(timerInterval);
  document.getElementById("final-score").textContent = score;
  document.getElementById("game-over").classList.remove("hidden");
  document.querySelectorAll(".balloon").forEach(b => b.remove());
}

function restartGame() {
  startGame();
}

function createBalloon() {
  const balloon = document.createElement("div");
  balloon.className = "balloon";

  balloon.style.left = Math.random() * (window.innerWidth - 60) + "px";
  balloon.style.backgroundColor = getRandomColor();

  balloon.addEventListener("click", () => {
    score++;
    document.getElementById("score").textContent = score;
    balloon.remove();
  });

  document.getElementById("game-area").appendChild(balloon);

  // Balon süresi dolunca yok olsun
  setTimeout(() => {
    if (document.body.contains(balloon)) balloon.remove();
  }, 6000);
}

function getRandomColor() {
  const colors = ["red", "blue", "green", "yellow", "purple", "orange"];
  return colors[Math.floor(Math.random() * colors.length)];
}

window.onload = startGame;
