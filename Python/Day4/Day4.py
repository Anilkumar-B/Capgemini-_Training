
# # def fibonacci(n):
# #     start=0
# #     next=1
# #     for i in range(n):
# #         print(start)
# #         temp=start
# #         start=next
# #         next=temp+next
# #     return start

# # def main():
# #     n=int(input("Enter the number of terms: "))
# #     print(fibonacci(n))
    
# # main()

# # import array
# # arr=array.array()
# # arr.append(1)
# # print(arr)

# # l4=list(range(-4,4))

# # def loop():
# #     arr=[]
# #     for i in range(10):
# #         arr.append(i)
# #     print(arr)
# # loop()

# # import array


# # l1=[]
# # print("1. an emptylist:",l1)

# # l2=[1,2,3,4,5]
# # print("2. A list with elements:",l2)  

# # l3=['abc',['def','ghi']]
# # print("3. A list with nested list:",l3)

# # l4=list('spam')
# # print("4. A list created with string spam:",l4)

# # l5=list(range(-4,4))
# # print("5. A list created with range:",l5)

# # l6=[10,20,30,40,50]
# # print("6. A list with index 2 of l6:",l6[2])

# # l7=['x',[1,2,3,4],'y']
# # print("7. A list with index 1 of l7:",l7[1][2])

# # #slicing a list
# # l8=[10,20,30,40,50]
# # print("8. A list with index 1 to 3 of l8:",l8[1:3])
# # print("9. length of l8:",len(l8))

# # #demonstrating nested indexing an slicing together
# # l9=[18,[1,2,3,4,5],20]
# # print("10a. A list with index 1 to 3 of l9:",l9[1])
# # print("10b. length of l9:",l9[1][3])
# # print("10c. A list with index 1 to 3 of l9:",l9[1][1:3])

# # #Summmary of lists:
# # print("\nSummary of lists:")
# # print("L1",l1)
# # print("L2",l2)
# # print("L3",l3)
# # print("L4",l4)
# # print("L5",l5)
# # print("L6",l6)
# # print("L7",l7)
# # print("L8",l8)
# # print("L9",l9)


# # list=[1,2,3,4,5]

# # print("1. List:",list)
# # print("2. List with index 1:",list[1])
# # print("3. List with index 1 to 3:",list[1:3])
# # print("4. Length of list:",len(list))
# # print("5.Sum of list:",sum(list))
# # print("6. Maximum of list:",max(list))
# # print("7. Minimum of list:",min(list))
# # print("8. List with index 1 to 3:",list[1:3],"maximum number:",max(list[1:3]))
# # print("9. List with index 1 to 3:",list[1:3],"minimum number:",min(list[1:3]))
# # print("10. List with index 1 to 3:",list[1:3],"sum of numbers:",sum(list[1:3]))


# # #create a list with 5 elements
# # numbers=[int(input("Enter the number: ")) for i in range(5)]
# # #cal

# # total=sum(numbers)

# # print("Sum of numbers:",total)


# # #create a list with 5 elements
# # numbers=[int(input("Enter the number: ")) for i in range(5)]

# # #calcuate maximum number
# # maximum=

# # def max_number():
# #     numbers=[int(input("Enter the number: ")) for i in range(5)]
# #     numbers.sort()
# #     print("Maximum number:",numbers[0])
# #     print("Minimum number:",numbers[-1])
    
# # max_number()

# # def get_input():
# #     n=int(input("enter size of list: "))
# #     list_A=list(map(int,input(f"enter {n} elements: ").split()))
# #     return list_A
# # def max_number(list_A):
# #     return sorted(list_A)[0]

# # def min_number(list_A):
# #     return sorted(list_A)[-1]

# # def main():
# #     list_A=get_input()
# #     print("Maximum number:",max_number(list_A))
# #     print("Minimum number:",min_number(list_A))
# # main()


# # def get_input():
# #     nums = [int(input(f"Enter number {i+1}:")) for i in range((int(input("Enter the size of nums:"))))]
# #     return nums

# # def smallest(nums):
# #     small=nums[0]
# #     big=nums[0]
# #     for i in range(1, len(nums)):
# #         if nums[i] < small:
# #             small = nums[i]
# #         else:
# #             big=nums[i]
# #     return {big,small}

# # def main():
# #     nums = get_input()
# #     (big,small) = smallest(nums)
# #     print("Smallest Number:",big)
# #     print("Biggest Number:",small)  

# # main()

# #finding largest and smallest number in a list of prime numbers
# # def is_prime(n):
# #     if n<=1:  
# #         return False
# #     for i in range(2, int(n**0.5) + 1):  # Check up to the square root of n
# #         if n % i == 0:
# #             return False
# #     return True

# # def count_primes(n):
# #     list=[]
# #     for i in range(2, n + 1):
# #         if is_prime(i):
# #             list.append(i)
# #     return list

# # def main():
# #     n = int(input("Enter a number: "))
# #     list=count_primes(n)
# #     print("Prime numbers are:",list)
# #     print("Largest number:",max(list))
# #     print("Smallest number:",min(list))

# # main()

# # combinaion_list=[1,2,3,4]+[5,6,7,8]
# # print(combinaion_list)

# # samevaluelist=['abc']*3
# # print(samevaluelist)

# # print(str([1,2,3,4,5])+'34')

# # print([1,2,3,4,5]+list('34'))

# # print(3 in [1,2,3,4,5]) #memebership test

# # for x in [1,2,3,4,5]:
# #     print(x, end=' ') #iteration
    
# # res=[c*4 for c in 'SPAM'] #list comprehension
# # print(res)

# #palindrome 
# # def is_palindrome(s):
# #     return s==s[::-1]

# # def main():
# #     list=input("Enter the string: ")
# #     if is_palindrome(list):
# #         print("Palindrome")
# #     else:
# #         print("Not palindrome")
    
# # main()

# # def space_reduce(string):
# #     list1=list(string)
# #     start=0
# #     while start<len(list1):
# #         if list1[start]==' ' and list1[start+1]==' ':
# #             list1.pop(start)
# #         else:
# #             start+=1
# #     return ''.join(list1)


# # def is_palindrome(string):
# #     return string==string[::-1]
            
# # def main():
# #     string=input("Enter the string: ")
# #     print("Reduced string:",space_reduce(string))
# #     if is_palindrome(string):
# #         print("Palindrome")
# #     else:
# #         print("Not palindrome")

# # main()

# #dictionaries
# d={}
# print("1. Empty dictionary:",d)

# d={'spam':2,'eggs':3}
# print("2. Dictionary with elements:",d)

# d={'food':{'ham':1,'egg':2}}
# print("3. Dictionary with nested dictionary:",d)

# d=dict(name='Bob',age=40)
# print("4. Dictionary with keyword arguments:",d)

# d=dict(zip(['name','age'],['sandeep',22]))
# print("5. Dictionary with zip:",d)

# d=dict.fromkeys(['a','b','c'])
# print("6. Dictionary with fromkeys:",d)

# d=dict.fromkeys([1,2,3,4,5],[1,2,3,4])
# print("7. Dictionary with fromkeys:",d)

# d.keys()
# print("8. Dictionary with keys:",d.keys())

# d.values()
# print("9. Dictionary with values:",d.values())

# d.items()
# print("10. Dictionary with items:",d.items())

# d.copy()
# print("11. Dictionary with copy:",d.copy())

# d.get(key,default)
# print("12. Dictionary with get:",d.get('name','sandeep'))