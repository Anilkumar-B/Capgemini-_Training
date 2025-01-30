import math
a = int(input("enter a  "))
b = int(input("enter b  "))
c = int(input("enter c "))

d = pow(b, 2) - 4 * a * c
if d<=0:
    print("0")
else:
    r1 = (-b + math.sqrt(d)) / (2 * a)
    r2 = (-b - math.sqrt(d)) / (2 * a)
    print(f"The roots are : {r1} and {r2}")

