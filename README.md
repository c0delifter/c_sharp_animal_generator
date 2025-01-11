A quick demo showcasing the advantage of using inheritance in conjuction with interface segregation when creating .NET apps

# Project Structure
The solution is comprised of 2 projects:
1. animal_generator.app (an interactive .NET 7 console app)
2. animal_generator.models (a .NET 7 class library that is consumed by the former)

# Outcome
Once the console app is launched, we should see all 3 derived classes have their own implementation of the `MakeNoise()` method

![01](/images/01.PNG)

The advantage of marking the base class as `abstract` (as opposed to making it `private` or `virtual`) is that developers cannot create an instance of this class directly. 
They have to use one of the child classes instead.

![02](/images/02.PNG)