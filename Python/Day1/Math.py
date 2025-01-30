
import random
num=random.random()
print(num)

import math

#squrare root
num=25
res=math.sqrt(num)
print("square root of 25 is:",res)

#exponent
b=2
e=3
res1=math.pow(b,e)
print("exponent of 2 and 3 is:",res1)

#Absolute value
n=-4
res3=math.fabs(n)
print("absolute value of -4 is:",res3)

#Trigonomic functions
angle=math.radians(45)

ans=math.sin(angle)
print("sin of 45 is:",ans)

ans1=math.cos(angle)
print("cos of 45 is:",ans1)

ans2=math.tan(angle)
print("tan of 45 is:",ans2)

#logarithmic functions

num=10
res4=math.log10(num)
print("log of 10 is:",res4) 

#constants
print("Value of pi is:",math.pi)    
print("Euler's constant is:",math.e)


#rounding functions
num=10.6
res5=math.ceil(num)
print("ceil of 10.6 is:",res5)

num1=10.6
print("floor of 10.6 is:",math.floor(num1))

#Factorial
num=5
res6=math.factorial(num)
print("factorial of 5 is:",res6)

#gcd
num1=10
num2=5
res7=math.gcd(num1,num2)
print("gcd of 10 and 5 is:",res7)