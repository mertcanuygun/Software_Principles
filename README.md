# Software_Principles
Software principle definitions with simple examples


# --Single Responsibility Principle (SRP)

-It is the principle that states that each class should have only one responsibility. This way, it is aimed to achieve faster responding and easier to control classes.

-Single Responsibility Principle can be implemented by breaking classes into pieces according to their purposes.

A MusicApp project has been taken account in the examples. This project's model has a class named "Song". And in this class beside appropriate properties, there is "ArtistName" property. It looks fine at first sight but it would be wiser to design the project with seperated "Artist" class. Because, if artist details needed to be presented, then the song class would be affected by something that doesn't concern it directly.

In the GoodExample, it can be found that Artist has its own class seperated from Song class which will be easier to control if Artist details were needed.



# --Open/Closed Principle (OCP)

-It is the principle that states that classes and functions are needed to be closed to change of existing codes while they have the ability to obtain new features. It is aimed to achieve to gain the elasticity of expanding the class without changing the base characteristics.

-This principle is applied to the project by inheriting the common characteristics of the base class while making necessary expansions in each subclasses.

In the BadExample, a perimeter calculator method is designed. With each different shape calculation request, the method needs to be arranged because all geometric shapes have their own perimeter calculations. To avoid this, a base class will be created to inherit this method. Subclasses will be overwritten by their own formula.



# --Liskov Substitiution Principle (LSP)

-It is the principle that states the necessity of interchangeability between base and child classes. With this principle, the establishment of complex hierarchies between classes can be avoided.

-This principle can be applied with establishing interchangeability between base and child classes by making appropriate arrangements in the inheriting base class and diversification of interfaces.

In the BadExample, both premium and standard streaming service users are inherited same functions and some of the functions are not quite correct for the correspondent user type. So, the methods are seperated for user type with interfaces and inherited accordingly in the GoodExample to avoid violation of Liskov Substituation Principle.

Note: For the example's sake, interface segregation principle is severely broken in the example.



# --Interface Segregation Principle (ISP)

-It is the principle that states that it should be preferred to create more customized interfaces than to collect all of the responsibilities into a single interface.

-This principle is about reducing objects down to their smallest implementation, and removing dependencies. The result of implementing this principle is to have a lot of small, focused interfaces that define only what is needed.

In the BadExample, IProduct interface is designed only for trousers but it can be needed to add different type of product. Then IProduct will not work appropriately. In the GoodExample, interface is minimized to base properties and specific features are added under subclasses.



# --Dependency Inversion Principle (DIP)

-It is the principle that states that the upper classes should not depend on the lower level classes and both class levels should depend upon abstractions. 

-Also, abstractions should not depend on details. Details should depend on abstractions. This means, a change made in subclasses should not affect the base classes.

-This principle will ensure that the classes are very easy to maintain and agile to expand if needed.

In the BadExample, ChangingRoomServise is the upper class but it is highly dependent on BadSweater and BadTrousers lower classes. This is something that no one desires and to be able to avoid this problem all classes will depend on an abstract upper class.
