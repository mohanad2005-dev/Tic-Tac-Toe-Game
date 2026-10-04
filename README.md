# ❌⭕ Tic-Tac-Toe Game (C# WinForms)

A Desktop Tic-Tac-Toe (X-O) game built with C# and Windows Forms. The project features custom GDI+ line drawing for the game board, turn tracking, dynamic result detection with cell highlighting, and restart functionality.

---

## 🌟 Features

* **Custom Grid Design**: Uses GDI+ (`Paint` event) to dynamically render grid lines.
* **Turn Management**: Alternates turns between **Player 1** (`x`) and **Player 2** (`o`) and updates the `lbTurnAnswer` label.
* **Winning Combination Highlighting**: Changes the background color of the winning pattern to `ForestGreen` upon victory.
* **Game Status Detection**: Automatically evaluates match outcomes (`Player 1`, `Player 2`, `Draw`, or `In Progress`) via `Calculate_Resutl()`.
* **Restart Functionality**: A `btnRestartGame` button resets board labels, text colors, background colors, turn state, and status labels.

---

## 📸 Screenshots

<table>
  <tr>
    <td align="center"><b>Game In Progress</b></td>
    <td align="center"><b>Winner / Draw Highlight</b></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/76c1253c-f2e3-46fd-944c-df5fb545d8f2" alt="Game Play" width="400"></td>
    <td><img src="https://github.com/user-attachments/assets/7653f764-d210-4740-8f8f-34604171e336" alt="Game Over" width="400"></td>
  </tr>
</table>

---

## 🛠 Built With

* **Language**: C#
* **Framework**: .NET Framework / .NET Desktop SDK
* **UI Tooling**: Windows Forms (WinForms & GDI+ Graphics)
* **IDE**: Visual Studio

---

## 🚀 Getting Started

### Prerequisites

* Visual Studio 2019 / 2022 with the **.NET desktop development** workload installed.
* .NET Framework 4.7.2 or higher.

### Installation & Running

1. **Clone the repository:**

`git clone https://github.com/mohanad2005-dev/Tic-Tac-Toe-Game.git`

2. **Open the project:**

Double-click `Tic-Tac-Toe-Game.sln` to open it in Visual Studio.

3. **Build and Run:**

Press `F5` or click the green **Start** button in Visual Studio to compile and run the application.

---

## 📁 Project Structure

Tic-Tac-Toe-Game/
│
├── images/
│   ├── game-play.png
│   └── game-over.png
├── Form1.cs             # Game Logic (Turn handling, win evaluation, restart)
├── Form1.Designer.cs    # WinForms Generated UI Components
├── Program.cs          # Application Entry Point
└── Tic-Tac-Toe.csproj

---

## 📝 How to Play

1. Player 1 starts the game placing **X** on any available cell (`?`).
2. Player 2 places **O** on their turn.
3. Aligning 3 identical symbols horizontally, vertically, or diagonally wins the match and highlights the winning combination in green.
4. If all cells are filled without a winning row, the status updates to **Draw**.
5. Click **Restart Game** to reset the board and start a new round.

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
