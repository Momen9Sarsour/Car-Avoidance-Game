# Car Avoidance Game – C++ (Visual Studio)

A simple but fun C++ game built using **Visual Studio**.  
Your goal is to move your car, avoid incoming cars, and survive as long as possible.  
Once you collect **20 points**, the game becomes faster and more challenging.

---

## 🎮 Game Description

This project is a console-based car game where the player controls a car on the road and avoids other cars coming from the top of the screen.

### 🧩 Game Features

- 🚗 **Player Car Movement**  
  Move left and right to avoid oncoming cars.

- 🚧 **Obstacle Cars**  
  Randomly generated cars appear from above.

- ⭐ **Score System**  
  You gain points for every avoided car.

- ⚡ **Speed Increase Mechanism**  
  After reaching **20 points**, game speed increases automatically.

- 💥 **Collision Detection**  
  If the player hits an obstacle car → **Game Over**.

- 🖥️ **Console Graphics**  
  The game uses ASCII drawing and coordinate-based car movement.

---

## 📸 Example Gameplay (Console Output)

| CAR |
| |
| * * |
| * |
| * * |

Score: 18


---

## 🛠️ Technologies Used

- **C++**
- **Visual Studio**
- Console graphics (`gotoxy()`, cursor movement, ASCII art)
- Random generators (`rand()`)
- Loops, functions, basic OOP concepts

---

## 📂 Project Structure

/CarAvoidanceGame
├── source.cpp
├── car.h
├── road.h
├── collision.h
└── README.md

---

## ▶️ How to Run the Game

### 1️⃣ Requirements
- Visual Studio (2019 / 2022)
- C++ Desktop Development tools installed

### 2️⃣ Steps

1. Open **Visual Studio**
2. Create a new **Console C++ Project**
3. Add the provided source files
4. Build & Run (Ctrl + F5)

---

## 🧠 How the Game Works (Technical Overview)

### 🎯 **Movement**
Using functions like:
gotoxy(x, y);

to place the player's car and obstacle cars in the console window.

### 🎯 **Obstacle Generation**

Random positions:
int obstacleX = rand() % laneWidth;

### 🎯 **Speed Increase**

After scoring 20:
if(score >= 20) speed = speed - 10;

### 🎯 **Collision Check**
if(playerX == obstacleX && playerY == obstacleY)
    gameOver = true;

---

### 💡 **Possible Future Improvements**
- Add levels (Level 1, Level 2…)  
- Add sound effects 
- Add main menu & restart option  
- Add color effects using Windows API   

---


## 👤 About Me

**Momen Sarsour — Computer Systems Engineering**  
📧 Email: **momensarsour5@gmail.com**  
📱 WhatsApp: **+970567077179**

❤️ Thank you for checking out this project!

Feel free to star ⭐ the repository if you like it.
