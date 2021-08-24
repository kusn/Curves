Curves

Assignment 1. 2D curves evaluation application.
Design a small program in C++, C#, Java or any other object-oriented language that would implement
support of 2D curves hierarchy.
1. Support two types of 2D geometric curves – lines and ellipses. (See details below). Each curve
should be able to return a 2D point and a first derivative (2D vector) per parameter t along the curve.
2. Populate a container (e.g. vector or list) of objects of these types created with random or fixed
parameters.
3. Print coordinates of points and derivatives of all curves in the container at t=PI/4.
Requirements to the implementation:
1. The implementation must use virtual methods.
2. Has neither explicit memory deallocation nor memory leaks.
Curve definitions:
- All curves are parametrically defined, i.e. a point is calculated using some C(t) formula.
- Line is defined by its origin point O and direction D: C(t) = O + D*t.
- Ellipse is defined by its two radii, along X and Y axes.
Assignment 2. Compute triangulation on a conical surface
Design a small program in C++, C#, Java or any other object-oriented language that would compute
coordinates of triangle nodes used to display a conical surface (see below):
1. The application must use parameters: cone height, radius and number of segments on a circle. They
can be hard-coded in the code or can be command line arguments.
2. Print coordinates of triangle nodes in counter-clockwise order.
3. Extra assignment (optional, not mandatory): print a conical surface normal (3D vector) at each point
Pi.
A cone can be easily represented with N triangles (where N is a number of segments along its circle). Each
triangle is composed of three nodes (A, Pi, Pi+1) – see fig.1.
Fig.1. Triangulation of a cone
X, Y, Z coordinates of a node:
A: {0, 0, H}, where H is a cone height
Pi : {R * cos (2 * i / N), R * sin (2 * i / N), 0} , i=0,N-1 – see fig.2:
Fig.2 – triangulation nodes along the cone’s circle
