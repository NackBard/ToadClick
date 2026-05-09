# 🐸 ToadClick

A Unity mini-game collection featuring four playable games in one project: an idle clicker, Snake, Flappy Bird, and Doodle Jump. Built with **Unity 2019.4 LTS** and **C#**.

## 🎮 Play

> _Add a build download link or WebGL demo link here_

## 📸 Screenshots

> _Add screenshots of each game here_

## 🕹️ Games

### 🐸 Toad Clicker
An idle clicker game where you tap a toad to earn currency, then spend it on auto-generators that produce income passively over time.
- Tap button earns +1 coin per click with a visual green/red feedback animation (Coroutine)
- **Hunters** auto-generate +1 coin/sec each, cost scales: `100 + count × 20`
- **Farms** auto-generate +10 coins/sec each, cost scales: `300 + count × 100`
- Progress saved and restored between sessions with **PlayerPrefs**
- Mini-game panel launches Snake from within the Clicker scene via `SceneManager`

### 🐍 Snake (3D)
A classic Snake game in a 3D environment.
- Grid-based movement driven by a **Coroutine** that ticks every 0.4s
- Tail follows the head via a position-swap chain each tick
- Eating food spawns a new tail segment at the last tail position and respawns the apple at a random coordinate
- Direction input via on-screen arrow buttons with axis-lock (can't reverse direction)
- Death triggered by wall collision (`DeathSnake`) or self-collision (head hits `Tail` tag)

### 🐦 Flappy Bird (2D)
A faithful Flappy Bird clone using Unity's 2D physics.
- Tap/click applies an upward `Rigidbody2D` impulse force to the bird
- Pipes spawn on a **Coroutine** every 2 seconds at a random vertical offset
- Pipes scroll left each `FixedUpdate` frame at a constant speed
- Old pipes are destroyed when more than 10 are active (keeps memory clean)
- Collision with a pipe disables the `BirdMove` script, stopping the bird mid-air

### 🦘 Doodle Jump (2D)
A mobile-style Doodle Jump clone with accelerometer controls.
- Player moves horizontally using `Input.acceleration` (gyroscope / accelerometer)
- Platforms bounce the player upward on landing (`relativeVelocity.y < 0` check)
- Platform recycling: when a platform exits below the dead zone, it relocates 20–22 units above, creating an infinite world without extra instantiation
- Camera follows the player upward only (never scrolls down)
- Procedural platform generation at start with 3 columns (center, left, right)

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Engine | Unity 2019.4.18f1 LTS |
| Language | C# |
| Physics | Unity 2D Physics (Flappy Bird, Doodle Jump), 3D Colliders (Snake) |
| Persistence | PlayerPrefs (Clicker save state) |
| Scene Management | `SceneManager.LoadScene` |
| Async | Unity Coroutines (`IEnumerator` + `WaitForSeconds`) |

## 🏗️ Project Structure

```
Assets/
├── Scripts/
│   ├── Clicker/
│   │   ├── ClickManager.cs       # Click handler, shop, scene switching
│   │   └── GameManager.cs        # Passive income loop, PlayerPrefs save/load
│   ├── Snake/
│   │   ├── SnakeMove.cs          # Movement coroutine, tail chain, food pickup
│   │   ├── AppleSpawn.cs         # Initial apple spawn
│   │   └── DeathSnake.cs         # Wall death trigger
│   ├── FlappyBird/
│   │   ├── BirdMove.cs           # Click-to-flap with Rigidbody2D impulse
│   │   ├── PipeSpawn.cs          # Timed random pipe spawner + cleanup
│   │   ├── PipeMove.cs           # Pipe scroll in FixedUpdate
│   │   └── Death.cs              # Collision detection, disables bird movement
│   └── Doodle/
│       ├── Doodle.cs             # Accelerometer movement, Singleton instance
│       ├── Platform.cs           # Bounce physics + platform recycling
│       ├── PlatformGeneration.cs # Procedural initial level generation
│       └── Camera.cs             # One-direction camera follow
├── Scenes/
│   ├── SampleScene.unity         # Toad Clicker
│   ├── SnakeScene.unity          # Snake
│   ├── FlappyBird.unity          # Flappy Bird
│   └── DoodleJump.unity          # Doodle Jump
├── Prefabs/                      # SnakeHead, SnakeTail, Apple, Bird, Pipes, Platform
├── Sprites/                      # 2D sprites for each game
└── Materials/                    # 3D materials for Snake scene
```

## 🚀 Getting Started

### Prerequisites

- Unity 2019.4 LTS (or newer with backwards compatibility)

### Run in Editor

1. Clone the repository:
   ```bash
   git clone https://github.com/NackBard/ToadClick.git
   ```

2. Open the project folder in **Unity Hub**.

3. Open any scene from `Assets/Scenes/` and press **Play**.

## 🔮 Roadmap

- [ ] Main menu with game selection screen
- [ ] Score display and high score tracking
- [ ] Sound effects and background music
- [ ] Mobile build (Android/iOS)
- [ ] Doodle Jump: enemy obstacles and moving platforms

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

> Built with ❤️ using Unity 2019.4 LTS and C#
