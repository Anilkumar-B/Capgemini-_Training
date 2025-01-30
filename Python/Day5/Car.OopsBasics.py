
# class Car:
#     def __init__(self, brand, model): 
#         self.brand = brand
#         self.model = model

#     def display_info(self):
#         print(f"This car is a {self.brand} {self.model}.")

# car1 = Car("Toyota", "Corolla")
# car2 = Car("Honda", "Civic")

# car1.display_info()
# car2.display_info()

class Emolpyee:
    def __init__(self,name,salary):
        self.__name= name
        self.__salary=salary
    
    def set_salary(self,salary):
        self.__salary = salary

    def get_salary(self):
        return self.__salary
    
emp=Emolpyee("Alice",5000)
print("Salary before update: ", emp.get_salary())

emp.set_salary(7000)

print("Salary after update: ", emp.get_salary())


class Emolpyee:
    def __init__(self,name,salary):
        self.__name= name
        self.__salary=salary
    
    def set_salary(self,salary):
        self.__salary = salary

    def get_salary(self):
        return self.__salary
    
emp=Emolpyee("Alice",5000)
print("Salary before update: ", emp.get_salary())

emp.set_salary(7000)


class Employee:
    def __init__(self, name, salary):
        self.__name = name
        self.__salary = salary
        self.__food_allowance = 0
        self.__travel_allowance = 0
        self.__tax = 0
        self.__pf = 0
    
    def set_salary(self, salary):
        self.__salary = salary

    def get_salary(self):
        return self.__salary

    def set_food_allowance(self, food_allowance):
        self.__food_allowance = food_allowance

    def get_food_allowance(self):
        return self.__food_allowance
    
    def set_travel_allowance(self, travel_allowance):
        self.__travel_allowance = travel_allowance

    def get_travel_allowance(self):
        return self.__travel_allowance
    
    def set_tax(self, tax):
        self.__tax = tax

    def get_tax(self):
        return self.__tax
    
    def set_pf(self, pf):
        self.__pf = pf

    def get_pf(self):
        return self.__pf
    
    def calculate_gross_salary(self):
        
        return self.__salary + self.__food_allowance + self.__travel_allowance
    
    def calculate_net_salary(self):
        return self.calculate_gross_salary() - (self.__tax + self.__pf)
    
name = input("Enter employee name: ")
salary = float(input("Enter salary: "))

emp = Employee(name, salary)

food_allowance = float(input("Enter food allowance: "))
travel_allowance = float(input("Enter travel allowance: "))


emp.set_food_allowance(food_allowance)
emp.set_travel_allowance(travel_allowance)


pf = float(input("Enter Provident Fund deduction: "))
emp.set_pf(pf)

tax_percentage = float(input("Enter tax percentage: "))
tax = (tax_percentage / 100) * emp.calculate_gross_salary()
emp.set_tax(tax)

print("Employee Name: ", name)
print("Gross Salary: ", emp.calculate_gross_salary())
print("Food Allowance: ", emp.get_food_allowance())
print("Travel Allowance: ", emp.get_travel_allowance())
print("Provident Fund Deduction: ", emp.get_pf())
print("Tax Deduction: ", emp.get_tax())
print("Net Salary: ", emp.calculate_net_salary())





