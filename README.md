# C# Patterns

Have cons and pros

### Factory Method

Pros:
* When it is not known in advance what type of objects need to be created
* When the system should be independent of the process of creating new objects and extensible: it can easily enter new classes whose objects the system should create.
* When the creation of new objects must be delegated from the base class to the classes of the heirs
Cons:
* For each new product you need to create your own creator class

### Abstract Factory

Pros:
* When the system should not depend on the way of creating and placing new objects
* When the objects that need to be created must be used together and interconnected
Cons:
* If we want to add a new object to the superhero's configuration, for example, the type of clothes, then we'll have to redo the factory classes and superhero class. Therefore, the possibilities for expansion in this pattern have some limitations.

### Singleton

Singleton allows you to create an object only if you need it. If an object is not needed, it will not be created. This is the difference between a singleton and global variables.