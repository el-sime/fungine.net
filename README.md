# Fungine.net

A basic game engine for learning porpuses.

## 0 - Intro and setup

- Install dotnet
- Install Monogame template
- `dotnet new sln`
- `dotnet new mgdesktopgl --name fungine`
- `dotnet new xunit --name fungine.test`

## 1 - Getting a character on the screen

### 1.1 Just load an image

- Add content with mgcb-editor
- Load the spritesheet
- Draw the image

### 1.2 Draw one frame of the spritesheet

- Identify the variables we need
- Add them as members of the Game class
- Calculate the base rectangles
- Calculate the source Rectangle origin

### 1.3

First refactoring. Create a class for the character.
Second refactoring, create the Animation class
**Hard requirement 1 spritesheet per animation**, for now.
