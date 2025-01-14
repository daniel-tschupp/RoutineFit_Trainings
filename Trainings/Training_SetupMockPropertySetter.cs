using Moq;

namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{
    public interface ITest
    {
        int MethodWithReturn();
    }

    [TestMethod]
    public void Training_SetupMethodWithReturnValue()
    {
        // Use Moq Framework to setup a mock object for the ITest Interface MethodWithReturn() method that returns pValue.
        // Verify the returned value. Also verify that the method was called only once.
        int pValue = 6;
        Assert.IsFalse(true);
    }
    public void GoToSolution() => this.Solution();

    [TestInitialize]
    public void Setup()
    {
        _testMock = new Mock<ITest>();
    }

    private Mock<ITest> _testMock;
}































public partial class TrainingSpace 
{
    int pValue = 6;
    _testMock.Setup(x => x.MethodWithReturn()).Returns(pValue);
    var myProperty = _testMock.Object.MethodWithReturn();
    
    Assert.AreEqual(pValue, myProperty);
    _testMock.Verify(x => x.MethodWithReturn(), Times.Once);
}
