# Conway's Game of Life

## What is Conway's Game of Life?

[Conway's Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life) is a cellular automat created by **J.H. Conway** in 1970. The evolution of the universe is determined by its initial state.

## Rules

The universe is a two-dimensional orthogonal grid filled with square cells, each of which is in one of two possible states, _live_ or _dead_. Every cell interacts with its eight neighbours (horizontally, vertically and diagonally adjacent). At each step in time, the next state of each cell is determined by these 4 rules:

1. Any live cell with less than two live neighbours dies. (_Underpopulation_)
2. Any live cell with two or three live neighbours remains live. (_Next generation_)
3. Any live cell with more than three live neighbours dies. (_Overpopulation_)
4. Any dead cell with exactly three live neighbours becomes a live cell. (_Reproduction_)

## The Controls

- Dead cells become live ones by **clicking** on them while the simulation is not running.
- Pressing **H key** turns on the **"hover mode"**. During this mode you can simply move the mouse over the dead cells you want to turn to live cells.
- Once you are ready to **start the simulation**, press **Enter key**. If the Enter key is pressed again, the **simulation is paused**.
- In paused mode, you can **reset the cells** (to all dead) by pressing the **R key**.
- The board **window is terminated** by pressing the **Escape key**.

## The Settings

The max size of the board is 100 cells by 65 cells. Tick indicated the delay between two generations (the highed the Tick, the more time you have to observe the current state of the board). The max Tick value is 1 second.

## How to start the game?
To start the game, download Release folder and run the executable.
\
\
\
_made by_ Marek Balvín, 2021
