# Adventure Quest RPG :space_invader:

Adventure Quest RPG is a console-based role-playing game where players can explore different locations, battle various monsters, and manage their inventory. The game features an engaging combat system and challenges players with both regular and boss monsters.

## Table of Contents
- [Getting Started](#getting-started)
- [Game Features](#game-features)
- [Game Mechanics](#game-mechanics)
- [Classes and Interfaces](#classes-and-interfaces)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites
- .NET 7.0 
- A code editor like Visual Studio

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/Hayaalsughair/Adventure-Quest-RPG.git
    ```
2. Navigate to the project directory:
    ```sh
    cd Adventure-Quest-RPG
    ```
3. Build the project:
    ```sh
    dotnet build
    ```
4. Run the project:
    ```sh
    dotnet run --project Adventure_Quest_RPG
    ```

## :star2: Game Features :star2:

- **Explore Locations**: Discover new locations like Forest, Cave, and Tower.
- **Battle Monsters**: Engage in battles with regular and boss monsters.
- **Inventory Management**: View and use items from your inventory.
- **Progression**: Fight through different levels and encounter increasingly difficult monsters.

## Game Mechanics

### Main Menu
- **[D] Discover a new location**
- **[S] Show your current location**
- **[A] Attack a monster**
- **[V] View the inventory**
- **[Q] Quit the game**

### Combat System
- Players and monsters take turns to attack.
- Damage is calculated based on attack power and defense.
- Players win by reducing the monster's health to zero.
- The game ends if the player's health reaches zero.

### Inventory System
- Players can view their inventory.
- Items can be used to restore health or provide other benefits.

## Classes and Interfaces

### Adventure
- Manages the player's actions and game loop.
- Allows players to discover locations, attack monsters, and view inventory.

### BattleSystem
- Handles the combat mechanics between the player and monsters.
- Includes methods like `Attack` and `StartBattle`.

### Character (abstract class)
- Base class for both players and monsters.
- Implements `IBattleStates` interface for battle mechanics.

### Player
- Inherits from `Character`.
- Represents the player in the game.

### Monster
- Inherits from `Character`.
- Represents a generic monster.

### RegularMonster and BossMonster
- Specialized classes for different types of monsters.

### Inventory and Items
- Manage the items the player can use during the game.

### Interfaces
- `IBattleStates`: Defines methods for calculating damage and managing health.

## Unit Testing 

Unit tests are written using XUnit. The test project is located in the `Adventure-Quest-RPG_Test` directory.

### Running Tests :arrow_forward:
1. Navigate to the test project directory:
    ```sh
    cd Adventure-Quest-RPG_Test
    ```
2. Run the tests:
    ```sh
    dotnet test
    ```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
