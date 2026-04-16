x1= float(input("x1: "))
y1= float(input("y1: "))
x2= float(input("x2: "))
y2= float(input("y2: "))

dx = x2-x1;
dy = y2-y1;

import math
distancia = math.sqrt((dx**2)+(dy**2))

print(f"Distancia entre los puntos: {distancia}")
