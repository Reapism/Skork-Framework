![image](https://i.imgur.com/yk7Gm3O.png)
<div align="left">
  <a href="https://twitter.com/iReapism">
    <img src="https://img.shields.io/badge/twitter-%40iReapism-55acee.svg?style=flat-square">
  </a>
  <a href="./LICENSE">
    <img src="https://img.shields.io/badge/license-apache-blue.svg?style=flat-square">
  </a>
</div>

**Skork Engine Framework [Private Repository]** is the sequel to the original [Skork](https://github.com/Reapism/Skork) project.

## What is Skork Engine?
**Skork** (SCORE-K) is a custom programming language for writing a game with rules *you define*. Skork engine allows you to 
test code in a visual way using *sprites*. You can visual your code using primitive variables, loops, and sprites. My audience 
is anyone interested enough to write in a simplified programming language, and visualize code in a different way! Feel free to 
fork it and make any update/addition/deletion you want. 

> ***But remember to do all such activities in accordance to the [current license](https://github.com/Reapism/Skork-Engine/blob/master/LICENSE).***

## All Skork related repositories
* [~~Skork old discontinued project~~](https://github.com/Reapism/Skork)
* [Windows based GUI](https://github.com/Reapism/Skork-Engine) implementation of the Skork Engine Framework.
* **Skork Engine framework itself! (private)**
* *Web based implementation of the Skork Engine Framework.* (COMING SOON)

There is also a web based implementation of the Skork framework. This will be *slowly developed overtime*!

# FAQ 
### Is the Skork engine open sourced?
This project itself is open sourced. This refers to the GUI implementation of the Skork Engine, and the **interaction** with the Skork-Engine framework. The *actual* Skork framework is **not open sourced**. Since the rebirth of this project, I decided this project
fits better with a data driven model. This means all profiles, preferences, (possibly) and projects will be in the cloud.
An emphasis on a database model for this software means that database connectivity, and manipulation *shouldn't* be public (for
security reasons).

### What is the Skork Engine framework?
It's the barebones API for parsing text into Skork code, compiling it, interpreting it, and running it! The Skork framework
is responsible for delegating, managing, and executing resources based on the priortity of each task or instruction it interprets. 
This project is an **implementation** of the framework. The compiled framework will be available for use with its own license. The source code is not open sourced (See above). By itself, it doesn't do much. It needs an application to interact with. 

### What is Skork Engine used for?
Since its a programming language, technically, its uses are up to you. What makes this simplified programming language
different than the others is that it is revolved around **sprites** which are a visual indicator of your code. Writing code
around these sprites will enable you to visualize your code. Overtime, there will be other **"entities"** you can instantiate
and interact with! You can create a "game" with a ruleset you define statically or dynamically through code. It provides an
easy way to visualize a ruleset or function.

### Design goals?
* 100% S.O.L.I.D principles
* Modularity (Multiple NuGet packages, use what you need)
* Lightweight (Ties into modularity)
* Simple (User friendly naming and documentation)

### What is Future of the Skork Engine
I want to develop this engine to the maximum. Possibly to be part of something bigger. This may include this software being aquired
by a third party.
