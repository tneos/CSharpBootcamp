namespace InheritenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowFields();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessFields();
            derivedClass.ShowFields();
        }
    }
}

// Base class
class BaseClass
{
    // access modifiers
    public int publicField;
    protected int protectedField;
    private int privateField;

    public void ShowFields()
    {
        Console.WriteLine($"Public: {publicField}, " + $"Protected: {protectedField} " + $"Private: {privateField} ");
    }
}
// class Dog inherits properties and methods from base class
class DerivedClass : BaseClass
{
    public void AccessFields()
    {
        publicField = 1;
        protectedField = 6;
    }
}
