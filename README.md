# Conway's Game of Life

## What is Game of Life?
[Conway's Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life) is a cellular automation created by J.H. Conway in 1970.
The evolution is defined only by the game's initial state.\
I chose to develop it in Windows Forms using C#, because it offers an easy UI interaction.

## Rules of the game
The board is a two-dimensional space filled by square cells (16px by 16px in this implementation), each of which is in one of
two possible states - dead or alive.\
Every cell interacts with its 8 neighbours (horizontally, vertically and diagonally adjacent cells). At each step in time,
 the next state of each cell is defined by 4 rules:
 1. Any live cell with fewer than two live neighbours dies. *(Underpopulation)*
 2. Any live cell with two or three live neighbours remains alive. *(Next generation)*
 3. Any live cell with more than three live neighbours dies. *(Overpopulation)*
 4. Any dead cell with exactly three live neighbours becomes alive. *(Reproduction)*
By applying these rules, new generations of cells are created.

## The settings
The max size of the board is 100 cells by 65 cells. Ticks indicate how fast the transition happens (higher tick means longer delay between
current generation and the next).
- Cells are set to alive by clicking on them (live cells are black, dead are white).
- Hover mode is entered and exited by pressing H. The user can then move mouse across the board and "paint" the cells.
- The simulation start when Enter key is pressed. When the Enter key is pressed during simulation, the simulation is paused. 
During this time, it is possible to make changes to the current state of the board.
- R key resets all cells in paused mode.
