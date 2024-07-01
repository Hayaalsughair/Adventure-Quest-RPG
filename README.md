
# Adventure Quest RPG Console Application

## Overview
This console application simulates an RPG game where a player battles against monsters. The game demonstrates basic object-oriented programming principles, including inheritance, polymorphism, and encapsulation.

## Features
- Single-player mode: Player vs Monsters.
- Turn-based battle system.
- Interactive console-based gameplay.
- Exception handling for errors during the game.
- Unit tests using Xunit for core game logic.

## Project Structure
- `Program.cs`: Contains the entry point (`Main` method) for starting the game.
- `BattleSystem.cs`: Manages game flow, battle logic (`Attack`, `StartBattle`), and battle outcomes.
- `Character.cs`: Represents a character with properties (`Name`, `Health`, `AttackPower`, `Defense`) and a method (`CalcDamage`) to calculate damage.
- `Player.cs`: Represents a player with predefined attributes.
- `Monster.cs`: Represents a monster with predefined attributes.
- `RPG_GameTest`: Contains unit tests to verify game logic using Xunit.

## :boom: How to Play :boom:
1. Run the application.
2. The game initializes a player and a monster.
3. Follow the prompts on the console to attack and defend.
4. The battle continues until either the player or the monster is defeated.



## License
This project is licensed under the MIT License - see the LICENSE file for details.