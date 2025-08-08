function createBalloon() {
  const balloon = document.createElement("div");
  balloon.className = "balloon";

  // Rastgele pozisyon
  balloon.style.left = Math.random() * window.innerWidth + "px";
  balloon.style.top = Math.random() * window.innerHeight + "px";

  // Tıklanınca patlasın
  balloon.addEventListener("click", () => {
    balloon.remove(); // Balon silinir = patlamış olur
    // İstersen patlama efekti veya ses de ekleyebilirsin
  });

  document.getElementById("game-area").appendChild(balloon);
}

// Her 1 saniyede bir yeni balon oluştur
setInterval(createBalloon, 1000);
