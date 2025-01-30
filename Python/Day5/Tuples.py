
#tuples

T=()
print(T)
T1=(0,)
print(T1)
T3=0,'Ni',1.2,3
print(T3)
T4=('abc',('def','ghi'))
print(T4)
T5=tuple('spam')
print(T5)
T6 = (10, 20, 30, 40, 50)  
print(T6[0]) 
print(T6[2])
T7= (  (1, 2, 3),  (4, 5, 6),    (7, 8, 9)   )
print(T7[0][1]) 
print(T7[2][0])  

#sets

set1={'apple','mango','banana','apple'}
print(set1)
set2={'Brinjal','Tomato','potato'}


set3 = {"a", "b", "c"}
set4 = {1, 2, 3}

set5 = set3.union(set4)
print(set5)

set6 = {"google", "microsoft", "apple"}

set7 = set1.intersection(set6)
print(set7)


