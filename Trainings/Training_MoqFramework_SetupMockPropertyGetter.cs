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
    public void Training_MoqFramework_SetupMockPropertyGetter()
    {
        int expectedReturnValue = 6;
        var returnedValue = 0;

        MoqTestReturnPropertyValue(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnPropertyValue(int expectedPropertyValue, int returnedPropertyValue)
    {
        Assert.IsTrue(false, "Implement the Moq Framework to check if the property is read once and with correct value.");
    }
    [TestMethod]
    public void VerifySolution() => this.Solution();

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
        int expectedReturnValue = 6;
        var returnedValue = 0; 

        _testMock.SetupGet(x => x.MyProperty).Returns(expectedReturnValue);
        returnedValue = _testMock.Object.MyProperty;
        MoqTestReturnPropertyValue_Solution(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnPropertyValue_Solution(int expectedArgumentValue, int returnedValue)
    {
        Assert.AreEqual(expectedArgumentValue, returnedValue);
        _testMock.VerifyGet(x => x.MyProperty, Times.Once);
    }
}
