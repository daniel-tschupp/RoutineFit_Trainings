using Moq;

namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{
    public interface ITest
    {
        int MyProperty { get; set; }
    }

    [TestMethod]
    public void Training_SetupMockPropertyGetter()
    {
        // Use Moq Framework to setup a mock object for the ITest Interface Property Getter that returns pValue.
        // Verify the returned value. Also verify that the Property was called only once.
        this.Solution();
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
    private void Solution()
    {
        int pValue = 6;
        _testMock.SetupGet(x => x.MyProperty).Returns(pValue);
        var myProperty = _testMock.Object.MyProperty;

        Assert.AreEqual(pValue, myProperty);
        _testMock.VerifyGet(x => x.MyProperty, Times.Once);
    }
}
