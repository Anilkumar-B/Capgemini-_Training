class Parent:
    def __init__(self):
        self.bignose="7Cm"
    def display_parent(self):
        print("This is a parent class")

class Child(Parent):
    def __init__(self):
        super().__init__()
    def display_child(self):
        print("This is a child class")


child=Child()
child.display_child()
child.display_parent()
print(child.bignose)


# Base class for School

class School:
    def __init__(self):
        self.school_name = ""
        self.school_grade = ""

    def input_school_details(self):
        self.school_name = input("Enter the school name: ")
        self.school_grade = input("Enter the grade: ")

    def display_school_details(self):
        print("\n--- School Details ---")
        print(f"School Name: {self.school_name}")
        print(f"Grade: {self.school_grade}")

# Derived class for UG (inherits from School)
class UG(School):
    def __init__(self):
        super().__init__()  # Call the constructor of the base class
        self.college_name = ""
        self.degree = ""
        self.year = ""

    def input_ug_details(self):
        self.college_name = input("Enter the college name: ")
        self.degree = input("Enter the degree: ")
        self.year = input("Enter the year of enrollment: ")

    def display_ug_details(self):
        print("\n--- UG Details ---")
        print(f"College Name: {self.college_name}")
        print(f"Degree: {self.degree}")
        print(f"Year of Enrollment: {self.year}")

# Main function to demonstrate functionality
def main():
    # Create an object of UG (derived class)
    ug_student = UG()
    
    # Input details for school and UG
    print("Enter School Details:")
    ug_student.input_school_details()

    print("\nEnter UG Details:")
    ug_student.input_ug_details()

    # Display all details
    ug_student.display_school_details()
    ug_student.display_ug_details()

# Run the program
if __name__ == "__main__":
    main()
