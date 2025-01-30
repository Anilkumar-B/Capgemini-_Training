class School:
    def __init__(self,name,location):
        self.name=name
        self.location=location
    def display(self):
        print(f"Name:{self.name}")
        print(f"Location:{self.location}")
class College(School):
    def __init__(self,name,location,ug_courses):
        super().__init__(name,location)
        self.ug_courses=ug_courses
    def display(self):
        super().display()
        print(f"UG Courses:{self.ug_courses}")
class University(College):
    def __init__(self,name,location,ug_courses,pg_courses):
        super().__init__(name,location,ug_courses)
        self.pg_courses=pg_courses
    def display(self):
        super().display()
        print(f"PG Courses:{self.pg_courses}")
if  __name__=='__main__':
    name=input("Enter the name:")
    location=input("Enter the location:")
    ug_courses=input("Enter the ug courses:")
    pg_courses=input("Enter the pg courses:")
    u=University(name,location,ug_courses,pg_courses)
    u.display()