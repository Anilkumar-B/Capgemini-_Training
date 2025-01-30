# def display(name):
#     print(f"my name is: {name} good morning")

# name="sandeep"
# display(name)

# def area(len,bred):
#   return len*bred
# len=10
# bred=20
# print(f"Area of rectangle is: {area(len,bred)}")



# def avg_func(avg): #printing average of four numbers
#     print(f'Average of four numbers is: {avg}')
    
# def input_num(): #taking input of four numbers
#     num1=int(input())
#     num2=int(input())
#     num3=int(input())
#     num4=int(input())
#     return {num1,num2,num3,num4}

# def calculate(num1,num2,num3,num4): #sum and average of four numbers
#     return (num1+num2+num3+num4)//4

# def sum(num1,num2,num3,num4): #sum of four numbers
#     return (num1+num2+num3+num4)

# def sum_avg(data):  #average of sum
#     return data//4

# def main():
#     (num1,num2,num3,num4)=input_num()
#     avg=sum(num1,num2,num3,num4)
#     data=sum_avg(avg)
#     avg_func(data)

# main()


# def biggest_num(val):
#     print(f'biggest of three numbers: {val}')
    
# def input_data():
#     x=int(input("enter first number: "))
#     y=int(input("enter second number: "))
#     z=int(input("enter third number: "))
#     return {x,y,z}
# def calculate_big(x,y,z):
#     if(x>y and x>z):
#         return x
#     elif(y>x and y>z):
#         return y
#     else:
#         return z

# def main():
#     (x,y,z)=input_data()
#     val=calculate_big(x,y,z)
#     biggest_num(val)

# main()


# def biggest(val):
#     print(f'biggest of three numbers: {val}')
# def input_data():
#     x=int(input("enter first number: "))
#     y=int(input("enter second number: "))
#     z=int(input("enter third number: "))
#     if(x>y and x>z):
#         return {"x is biggest":x}
#     elif(y>x and y>z):
#         return {"y is biggest":y}
#     else:
#         return {"z is biggest":z}
    
# def main():
#     val=input_data()
#     biggest(val)
    
    
# main()
    
# import dis
# def multiplication(a,b):
#     res=a*b
    
# a=3
# b=4 
# result=multiplication(a,b)
# print("result is:",result)
# print(dis.dis(multiplication))   
    
# import dis
# def mutliply_of_two_numbers(a,b):
#     a=2
#     return a*b
# def get_input_5():
#     a=int(input())
#     b=int(input())
#     return {a,b}

# def display(data):
#     print(f'the multiplied number is {data}')
    
# def main():
#     (a,b)=get_input_5()
#     ans=mutliply_of_two_numbers(a,b)
#     display(ans)
# dis.dis(main)
# main()
    
# import dis

# def loop(n):
#     for i in range(n):
#         print(i)
# dis.dis(loop)

#prime numbers using for loop

# def is_prime(n):
#     if n%2==0:
#         return "not prime"
#     if n==1:  
#         return "not prime"
#     if n==2:
#         return "least Number in prime"
#     for i in range(2, int(n**0.5) + 1):  # Check up to the square root of n
#         if n % i == 0:
#             return "not prime"
#     return "prime"

# def prime_number(n):
#     return is_prime(n)  # result from is_prime

# def count_primes(n):
#     count = 0
#     for i in range(2, n + 1):
#         if is_prime(i) == "prime":
#             count += 1
#     return count+1

# def main():
#     n = int(input("Enter a number: "))
#     print(prime_number(n))  # Print the result
#     print(count_primes(n))

# main()

#prime numbers upto n values

# def is_prime(n):
#     if n<=1:  
#         return False
#     for i in range(2, int(n**0.5) + 1):  # Check up to the square root of n
#         if n % i == 0:
#             return False
#     return True

# def prime_number(n):
#     return is_prime(n)  # result from is_prime

# def count_primes(n):
#     count = 0
#     for i in range(2, n + 1):
#         if is_prime(i):
#             print("Prime numbers are:",i)
#             count+= 1
#     return count

# def main():
#     n = int(input("Enter a number: "))
#     print(prime_number(n))  # Print the result
#     print(count_primes(n))
    
# main()

#using while loop
# def prime_num(n):
#     if n<2:
#         return False
#     if n%2==0:
#         return False
#     i=2
#     while i<=n//2:
#         if n%i==0:
#             return False
#         i+=1
#     return True

# def no_of_primes(n):
#     count=0
#     i=2
#     while i<=n:
#         if prime_num(i):
#             print("prime numbers are:",i)
#             count+=1
#         i+=1
#     return count+1

# def main():
#     n=int(input("Enter a number: "))
#     if prime_num(n):
#         print("prime number")
#     else:
#         print("not prime number")
#     print("Number of prime numbers are: ",no_of_primes(n))
        
# main()

#extra code
# def prime_number(n):
#     for i in range(n):
#         if prime_num(i):
#             print("prime numbers are:",i)
#         else:
#             print("not prime numbers are:",i)
#     return i



            