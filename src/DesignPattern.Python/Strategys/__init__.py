
class FlyFactory(object):  
    @staticmethod
    def FlyWithWings():  
        print('Fly with wings.') 
         
    @staticmethod
    def FlyNoWay():  
        print('Fly no way.')
        
class QuackFactory:      
    @staticmethod
    def Quack():  
        print("gua gua")  
       
    @staticmethod
    def Squeak():  
        print("zhi zhi") 
       
    @staticmethod 
    def MuteQuack():  
        print("nothing") 
       
    
class Duck(object):  
    def __init__(self, fly, quack):
        self._fly = fly
        self._quack = quack
    
    def display(self):  
        pass      
    
    @property
    def fly(self):
        return self._fly
    
    @property
    def quack(self):
        return self._quack
    
  
class MallardDuck(Duck):  
    def __init__(self):  
        super(MallardDuck, self).__init__(FlyFactory.FlyWithWings,QuackFactory.MuteQuack)
  
    def display(self):  
        print('MallardDuck')
        
class RedheadDuck(Duck):  
    def __init__(self): 
        super(RedheadDuck, self).__init__(FlyFactory.FlyWithWings,QuackFactory.Quack)
  
    def display(self):  
        print("RedheadDuck")  
  
class RubberDuck(Duck):  
    def __init__(self):  
        super(RubberDuck, self).__init__(FlyFactory.FlyNoWay,QuackFactory.MuteQuack)
  
    def display(self):  
        print("RubberDuck") 
  
def sample():      
    for n in MallardDuck(),RedheadDuck(),RubberDuck():  
        n.display()  
        n.fly()  
        n.quack() 
        print   