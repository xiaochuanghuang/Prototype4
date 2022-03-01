How did you implement it?
First depend on the book said, created a Interface for it, IState is a abstract class, there is a function call update(), it is the override
function, such as c++ pure virtual function, it does not have definition and the class who inheritance this interface must implement this
Interface. Then for every states I created each class for them such as movement, Jump, hit.... These classes are all inheritance 
the IState interface. initialize those states object in the IState class, and make it static, then Delegate to the state in the main
mechanic class.

Would you do it differently? Justify your answer!
No, Because I think Bob the writer of the book, teaches us very straightforward, follows the book said is very helpful.

Did you use a different implement state pattern elsewhere? What for?

No.