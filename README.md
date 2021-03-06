# C# Patterns

## Factory Method

### Use:
* When it is not known in advance what type of objects need to be created
* When the system should be independent of the process of creating new objects and extensible: it can easily enter new classes whose objects the system should create.
* When the creation of new objects must be delegated from the base class to the classes of the heirs

## Abstract Factory

### Use:
* When the system should not depend on the way of creating and placing new objects
* When the objects that need to be created must be used together and interconnected

## Singleton

Singleton allows you to create an object only if you need it. If an object is not needed, it will not be created. This is the difference between a singleton and global variables.

## Prototype

### Use:
* When a particular type of an object to be created must be dynamically determined at run-time
* When it is undesirable to create a separate factory class hierarchy for creating product objects from a parallel class hierarchy (as is done, for example, when using the Abstract Factory pattern)
* When cloning an object is more preferable than creating it and initializing it using the constructor. Especially when it is known that an object can accept a small limited number of possible states.

## Builder

### Use:
* When the process of creating a new object should not depend on what parts of this object it consists of and how these parts are related to each other
* When it is necessary to ensure the receipt of various variations of the object in the process of its creation