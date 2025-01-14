A quick demo showcasing the advantage of using inheritance in conjuction with interface segregation when creating .NET apps

# Project Structure
The solution is comprised of 2 projects:
1. animal_generator.app (an interactive .NET 7 console app)
2. animal_generator.models (a .NET 7 class library that is consumed by the former)

# Challenge

From FM Global:

```
Consider you must build a system that calls for Dogs and Cats - which both speak.
Cat says "Meow".
Dog says "Woof".
How would you models this?

Hint: They are both Animals and all Animals Speak.
```

# Solution

There are several ways to solve this problem. Personally, I prefer a combination of inheritance, abstraction, and interfaces.

1. Have an `abstract` base class of Animal. Each animal has a unique `name` property. Hence, we mark it as `static`, since it's class specific - not instance specific.
2. While it's fine to inherit fields and properties from the base class, for methods I prefer to use interfaces. We create an interface called `IAnimalSpeak`.
3. Because each sub-class of `Animal` will have its own implementation of this method, we mark it as `abstract`.   
4. Note: We could've made this method `virtual` instead. The difference between the two is that a `virtual` method has a default implementation. Derived classes are welcome to `override` it. But they are not required to. 
5. Inside of the `animal_generator.app` project, we create an instance of each of the `Animal` sub-classes. 1 Cat, 1 Dog, 1 Pig. Each one them emits a different noise - despite the fact that all of them implement the same `MakeNoise()` method from the `IAnimaSound` interface. 

# Outcome
Once the console app is launched, we should see all 3 derived classes have their own implementation of the `MakeNoise()` method

![01](/images/01.PNG)

The advantage of marking the base class as `abstract` (as opposed to making it `private` or `virtual`) is that developers cannot create an instance of this class directly. 
They have to use one of the child classes instead.

![02](/images/02.PNG)
