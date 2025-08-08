let score = 0;
let timeLeft = 20;
const maxBalloons = 15;
const balloonIntervalTime = 700;
let balloonInterval;
let timerInterval;

function createBalloon() {
  const balloon = document.createElement('div');
  balloon.className = 'balloon';
  balloon.style.left = Math.random() * (window.innerWidth - 50) + 'px';
  balloon.style.bottom = '-80px';

  balloon.addEventListener('click', () => {
    score++;
    document.getElementById('scoreboard').textContent = 'Skor: ' + score;
    balloon.remove();
  });

  document.body.appendChild(balloon);

  setTimeout(() => {
    if(document.body.contains(balloon)) balloon.remove();
  }, 6000);
}

function startGame() {
  score = 0;
  timeLeft = 20;
  document.getElementById('scoreboard').textContent = 'Skor: 0';
  document.getElementById('timer').textContent = 'Süre: 20';

  balloonInterval = setInterval(() => {
    if(document.querySelectorAll('.balloon').length < maxBalloons) {
      createBalloon();
    }
  }, balloonIntervalTime);

  timerInterval = setInterval(() => {
    timeLeft--;
    document.getElementById('timer').textContent = 'Süre: ' + timeLeft;
    if(timeLeft <= 0) {
      clearInterval(timerInterval);
      clearInterval(balloonInterval);
      alert('Süre doldu! Skorun: ' + score);
      document.querySelectorAll('.balloon').forEach(b => b.remove());
    }
  }, 1000);
}

window.onload = () => {
  startGame();
};
  }, balloonIntervalTime);

  timerInterval = setInterval(() => {
    timeLeft--;
    document.getElementById('timer').textContent = 'Süre: ' + timeLeft;
    if(timeLeft <= 0) {
      clearInterval(timerInterval);
      clearInterval(balloonInterval);
      alert('Süre doldu! Skorun: ' + score);
      document.querySelectorAll('.balloon').forEach(b => b.remove());
    }
  }, 1000);
}

window.onload = () => {
  startGame();
};
