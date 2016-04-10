<h2>Toy Robot Simulator</h2>
This toy robot is a simulator of a toy robot that moves on a tabletop.
<br>A full requirements specification can be found here: <a href = "https://github.com/jeff1978/Toy-Robot-Simulator/blob/master/ToyRobotSimulator/App%20Specification.txt">/ToyRobotSimulator/App Specification.txt</a>

<h3>Usage</h3>
Toy Robot Simulator is a console application. It opens and gives the user instructions on how to place and interact with the toy.

<h2>Valid commands</h2>
PLACE X,Y,FACING

This puts the toy on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST. If the toy is already placed, issuing another valid PLACE command will place the toy in the newly specified location.

MOVE
This moves the toy one unit forward in the direction it is currently facing.

LEFT
This rotates the toy 90 degrees to the left (i.e. counter-clockwise) without changing the position.

RIGHT
This rotates toy 90 degrees to the right (i.e. clockwise) without changing the position.

REPORT
This announces the X,Y and direction of the toy by printing to the console.

<h2>Supported operating systems</h2>
Toy Robot Simulator should run on any Windows operating system. It has been tested on Windows 10 Home Edition 32-bit.

<h2>Installing</h2>
The application runs in a single executable file. The file can be downloaded from: <a href = "https://github.com/jeff1978/Toy-Robot-Simulator/blob/master/ToyRobotSimulator/bin/Debug/ToyRobotSimulator.exe">\ToyRobotSimulator\bin\Debug\ToyRobotSimulator.exe</a>

<h2>Running</h2>
The executable file can be opened by double clicking it. The user can follow instructions on the console and also use it to type in their input.

<h2>Development Notes and Acknowledgements</h2>
A full list of information sources can be found here: <a href = "https://github.com/jeff1978/Toy-Robot-Simulator/blob/master/ToyRobotSimulator/Acknowledgements.txt">\ToyRobotSimulator\Acknowledgements.txt.</a>

<h2>Issues</h2>
Existing issues can be logged on the <a href = "https://github.com/jeff1978/Toy-Robot-Simulator/issues">Issues page.</a>

<h2>Unit Testing</h2>
C# Test files are found here: <a href = "https://github.com/jeff1978/Toy-Robot-Simulator/tree/master/ToyRobotSimulator.Test">\ToyRobotSimulator.Test</a>
<br>Tests were run using the nuget packages: NUnit 2.6.4 and NUnit Test Adapter 2.0.0

<h2>Future Developement Work</h2>
The the design and use of the interfaces requires refactoring from their current working form.

<h2>Licence</h2>
Toy Robot Simulator is licensed under the GNU Lesser General Public License v.3.0

<h2>Why the LGPL?</h2>
The GPL is specifically designed to reduce the usefulness of GPL-licensed code to closed-source, proprietary software. The BSD license (and similar) do not mandate code-sharing if the BSD-licensed code is modified by licensees. The LGPL achieves the best of both worlds: an LGPL-licensed library can be incorporated within closed-source proprietary code, and yet those using an LGPL-licensed library are required to release source code to that library if they change it.
