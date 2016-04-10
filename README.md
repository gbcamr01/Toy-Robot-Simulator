**************************************

**                                  **

**        TOY SIMULATOR v1.0        **

**                                  **

**************************************


This toy robot is a simulator of a toy robot that moves on a tabletop. A full requirements specification can be found here.

Usage

Toy Robot Simulator is a console application. It opens and gives the user instructions on how to place and interact with the toy.

Valid commands

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

Supported operating systems

Toy Robot Simulator should run on any Windows operating system. It has been tested on Windows 10 Home Edition 32-bit.

Installing

The application runs in a single executable file. It can be downloaded from: \ToyRobotSimulator\bin\Debug\ToyRobotSimulator.exe

Running

The executable file can be opened by double clicking it. The user can follow instructions on the console and also use it to type in their input.

Development Notes and Acknowledgements

A full list of information sources can be found here: ToyRobotSimulator\Acknowledgements.txt.

Issues

Existing issues can be logged on the Issues page.

Unit Testing

C# Test files are found here: ToyRobotSimulator.Test
Tests were run using the following packages: NUnit 2.6.4 and NUnit Test Adapter 2.0.0

Future Developement Work

The the design and use of the interfaces requires refactoring from their current working form.

Licence

Toy Robot Simulator is licensed under the GNU Lesser General Public License v.3.0

Why the LGPL?

The GPL is specifically designed to reduce the usefulness of GPL-licensed code to closed-source, proprietary software. The BSD license (and similar) do not mandate code-sharing if the BSD-licensed code is modified by licensees. The LGPL achieves the best of both worlds: an LGPL-licensed library can be incorporated within closed-source proprietary code, and yet those using an LGPL-licensed library are required to release source code to that library if they change it.
