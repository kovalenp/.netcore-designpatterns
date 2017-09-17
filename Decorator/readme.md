# Decorator pattern
Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

# UML Diagram
![Decorator UML diagram](http://www.dofactory.com/images/diagrams/net/decorator.gif)

# Explanation
The classes and objects participating in this pattern are:

* **Component** (AbstractBurger)
defines the interface for objects that can have responsibilities added to them dynamically.
* **ConcreteComponent** (Cheesburger)
defines an object to which additional responsibilities can be attached.
* **Decorator**   (Decorator)
maintains a reference to a Component object and defines an interface that conforms to Component's interface.
* **ConcreteDecorator**   (Ketchup, ExtraOnion)
adds responsibilities to the component.

