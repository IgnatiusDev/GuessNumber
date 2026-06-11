# 🔢 GuessNumber

A simple and fun **number guessing** console game written in C#.  
The system randomly generates a number between 1 and 100. Your goal is to guess it. After each guess, you'll be told whether your guess is **too high** or **too low** until you get it right.

---

## 🎮 Game Rules

1. The program randomly generates an integer between **1 and 100**
2. You enter your guess in the console
3. The program responds with:
   - ✅ **Correct!** – and shows how many guesses it took
   - ⬆️ **Too high** – guess a lower number
   - ⬇️ **Too low** – guess a higher number
4. After guessing correctly, you can choose to:
   - Play another round
   - Exit the game

---

## 🚀 How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or higher

### Steps

```bash
# 1. Clone the repository
git clone https://github.com/yourusername/GuessNumber.git
cd GuessNumber

# 2. Run the game
dotnet run
