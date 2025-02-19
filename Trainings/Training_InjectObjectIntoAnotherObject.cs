namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{
    record ParameterObject(int Member);
    class TestClass
    {
        public int GetInjectedObjectMember() => 0;
    }

    [TestMethod]
    public void Training_InjectObjectIntoAnotherObject()
    {
        var obj = new ParameterObject(5);

        var myClass = new TestClass();

        VerifyInjection(obj, myClass);
    }

    private void VerifyInjection(ParameterObject obj, TestClass testClass)
    {
        Assert.AreEqual(obj.Member, testClass.GetInjectedObjectMember());
    }

    [TestMethod]
    public void VerifySolution() => this.Solution();
}































public partial class TrainingSpace
{
    class TestClassSolution
    {
        public ParameterObject InjectedObject { get; init; }
        public TestClassSolution(ParameterObject injectedObject) => InjectedObject = injectedObject;
        public int GetInjectedObjectMember() => InjectedObject.Member;
    }

    private void Solution()
    {
        var obj = new ParameterObject(5);

        var myClass = new TestClassSolution(obj);

        VerifyInjectionSolution(obj, myClass);
    }

    private void VerifyInjectionSolution(ParameterObject obj, TestClassSolution testClass)
    {
        Assert.AreEqual(obj.Member, testClass.GetInjectedObjectMember());
    }
    
}
