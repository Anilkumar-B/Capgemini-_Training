from abc import ABC, abstractmethod

class Father(ABC):
    @abstractmethod
    def disp(self):
        pass
    def show(self):
        print("Concrete Method")
    
class Son(Father):
    def disp(self):
        print("Son is implementing the abstract method")

class Daughter(Father):
    def disp(self):
        print("Daugher is implementing the abstract method")

s=Son()
s.disp()
s.show

d=Daughter()
d.disp()
d.show()