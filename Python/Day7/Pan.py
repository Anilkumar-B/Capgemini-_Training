from abc import ABC,abstractmethod
class Person(ABC):
    def __init__(self, name, age):
        self.name = name
        self.age=age
        self.pancard_number=None
    def set_pancard(self,pancard_number):
        self.pancard_number=pancard_number
    @abstractmethod
    def display(self):
        pass
class Father(Person):
    def __init__(self,name,age):
        super().__init__(name,age)
    def display(self):
        print(f"Father Name:{self.name},Father Age:{self.age},FatherPancard:{self.pancard_number}")
class Son(Father):
    def __init__(self,name,age):
        super().__init__(name,age)
    def display(self):
        print(f"Son Name:{self.name},Son Age:{self.age},SonPancard:{self.pancard_number}")
father=Father("Surya",49)
son=Son("Shanmuk",21)
father.set_pancard("#12212221")
son.set_pancard("1122#")
son.display()
father.display()