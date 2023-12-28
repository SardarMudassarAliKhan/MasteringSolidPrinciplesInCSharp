In C#, the SOLID principles are a set of five design principles that help make software more understandable, flexible, and maintainable. Here they are with examples:

1. Single Responsibility Principle (SRP)
A class should have only one reason to change.

Example:
// Without SRP
public class Employee {
    public void CalculateSalary() {
        // Calculates salary
    }

    public void GenerateReport() {
        // Generates employee report
    }
}
Refactored using SRP:
public class Employee {
    public void CalculateSalary() {
        // Calculates salary
    }
}

public class ReportGenerator {
    public void GenerateReport(Employee employee) {
        // Generates employee report
    }
}
2. Open/Closed Principle (OCP)
Software entities should be open for extension but closed for modification.

Example:
// Without OCP
public class Circle {
    public double Radius { get; set; }

    public double Area() {
        return Math.PI * Radius * Radius;
    }
}

// Adding a new shape requires modifying existing code.
public class Square {
    public double Side { get; set; }

    public double Area() {
        return Side * Side;
    }
}
Refactored using OCP:
public abstract class Shape {
    public abstract double Area();
}

public class Circle : Shape {
    public double Radius { get; set; }

    public override double Area() {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape {
    public double Side { get; set; }

    public override double Area() {
        return Side * Side;
    }
}
3. Liskov Substitution Principle (LSP)
Objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program.

Example:
// Without LSP
public class Rectangle {
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int CalculateArea() {
        return Width * Height;
    }
}

public class Square : Rectangle {
    public override int Width {
        get => base.Width;
        set {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height {
        get => base.Height;
        set {
            base.Width = value;
            base.Height = value;
        }
    }
}
Refactored using LSP:
public abstract class Shape {
    public abstract int Area();
}

public class Rectangle : Shape {
    public int Width { get; set; }
    public int Height { get; set; }

    public override int Area() {
        return Width * Height;
    }
}

public class Square : Shape {
    public int Side { get; set; }

    public override int Area() {
        return Side * Side;
    }
}
4. Interface Segregation Principle (ISP)
Clients should not be forced to depend on interfaces they do not use.

Example:
// Without ISP
public interface IWorker {
    void Work();
    void TakeBreak();
    void ClockOut();
}

// For a Robot, some methods are irrelevant.
public class Robot : IWorker {
    public void Work() {
        // Perform work
    }

    public void TakeBreak() {
        // Not applicable
    }

    public void ClockOut() {
        // Not applicable
    }
}
Refactored using ISP:
public interface IWorker {
    void Work();
}

public interface IBreakable {
    void TakeBreak();
}

public interface IClockable {
    void ClockOut();
}

public class Robot : IWorker {
    public void Work() {
        // Perform work
    }
}
5. Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions.

Example:
// Without DIP
public class LightSwitch {
    private readonly Bulb _bulb;

    public LightSwitch() {
        _bulb = new Bulb();
    }

    public void Toggle() {
        _bulb.Toggle();
    }
}

public class Bulb {
    public void Toggle() {
        // Toggle the bulb
    }
}
Refactored using DIP:
public interface ISwitchable {
    void Toggle();
}

public class LightSwitch {
    private readonly ISwitchable _device;

    public LightSwitch(ISwitchable device) {
        _device = device;
    }

    public void Toggle() {
        _device.Toggle();
    }
}

public class Bulb : ISwitchable {
    public void Toggle() {
        // Toggle the bulb
    }
}
These principles aim to create more maintainable, modular, and scalable code, promoting good design practices in object-oriented programming.
