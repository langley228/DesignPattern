

class OnlyOne(object):
    class __OnlyOne:
        def __init__(self):
            self.val = None
        def __str__(self):
            return 'self' + self.val
    instance = None
    def __new__(cls): # __new__ always a classmethod
        if not OnlyOne.instance:
            OnlyOne.instance = OnlyOne.__OnlyOne()
        return OnlyOne.instance
    def __getattr__(self, name):
        return getattr(self.instance, name)
    def __setattr__(self, name):
        return setattr(self.instance, name)


class OnlyOne:
    class __OnlyOne:
        def __init__(self, arg):
            self.val = arg
        def __str__(self):
            return repr(self) + self.val
    instance = None
    def __init__(self, arg=''):
        if not OnlyOne.instance:
            OnlyOne.instance = OnlyOne.__OnlyOne(arg)
        else:
            OnlyOne.instance.val = arg
    def __getattr__(self, name):
        return getattr(self.instance, name)

class Borg:
    _shared_state = {}
    def __init__(self):
        self.__dict__ = self._shared_state

class Singleton(Borg):
    def __init__(self, arg):
        Borg.__init__(self)
        self.val = arg
    def __str__(self): return self.val


class SingleTone(object):
    __instance = None
    def __new__(cls, val):
        if SingleTone.__instance is None:
            SingleTone.__instance = object.__new__(cls)
        SingleTone.__instance.val = val
        return SingleTone.__instance

class SingletonDecorator:
    def __init__(self,klass):
        self.klass = klass
        self.instance = None
    def __call__(self,*args,**kwds):
        if self.instance == None:
            self.instance = self.klass(*args,**kwds)
        return self.instance

class foo: pass


def sample():
    x = OnlyOne()
    x.val = 'sausage'
    y = OnlyOne()
    y.val = 'eggs'
    z = OnlyOne()
    z.val = 'spam'
    print(z)
    print(x)
    print(y)

    x = OnlyOne('sausage')
    y = OnlyOne('eggs')
    z = OnlyOne('spam')
    print(z)
    print(x)
    print(y)

    x = Singleton('sausage')
    print(x)
    y = Singleton('eggs')
    print(y)
    z = Singleton('spam')
    print(z)
    print(x)
    print(y)
    print(x is y is z)

    x = SingleTone('sausage')
    y = SingleTone('eggs')
    z = SingleTone('spam')
    print(z.val)
    print(x.val)
    print(y.val)
    print(x is y is z)


    x = foo()
    y = foo()
    z = foo()
    x.val = 'sausage'
    y.val = 'eggs'
    z.val = 'spam'
    print(x.val)
    print(y.val)
    print(z.val)
    print(x is y is z)