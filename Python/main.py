import math

class Circle:
    def __init__(self, radius:float=1.0):
        self.__radius = radius

    @property
    def Radius(self):
        return self.__radius
    
    @Radius.setter
    def Radius(self, radius:float):
        self.__radius = radius

    def area(self):
        return math.pi * pow(self.__radius, 2)

    def cir_info(self):
        return f"Circle: Radius = {self.__radius}, Area = {self.area():.2f}"

class Cylinder:
    def __init__(self, radius:float=1.0, length:float=1.0):
        self.__radius = radius
        self.__length = length
    
    @property
    def Radius(self):
        return self.__radius
    
    @Radius.setter
    def Radius(self, radius:float):
        self.__radius = radius

    @property
    def Length(self):
        return self.__length
    
    @Length.setter
    def Length(self, length:float):
        self.__length = length

    def area(self):
        return 2 * math.pi * self.__radius * (self.__radius + self.__length)
    
    def volume(self):
        return self.area() * self.__length

    def cylinder_info(self):
        return f"Cylinder: Radius = {self.__radius}, Length = {self.__length}, Area = {self.area():.2f}, Volume = {self.volume():.2f}"
    
class Rectangle:
    def __init__(self, width:float=1.0, height:float=1.0):
        self.__width = width
        self.__height = height

    @property
    def Width(self):
        return self.__width

    @Width.setter
    def Width(self, width:float):
        self.__width = width

    @property
    def Height(self):
        return self.__height
    
    @Height.setter
    def Height(self, height:float):
        self.__height = height

    def area(self):
        return self.__width * self.__height
    
    def rec_info(self):
        return f"Rectangle: Width = {self.__width}, Height = {self.__height}, Area = {self.area():.2f}"

cir1 = Circle()
print(cir1.cir_info())
cir1.Radius = 5.0
print(cir1.cir_info())

cy1 = Cylinder()
print(cy1.cylinder_info())
cy1.Radius = 2.0
cy1.Length = 3.0
print(cy1.cylinder_info())

rec1 = Rectangle()
print(rec1.rec_info())
rec1.Width = 6.0
rec1.Height = 2.0
print(rec1.rec_info())