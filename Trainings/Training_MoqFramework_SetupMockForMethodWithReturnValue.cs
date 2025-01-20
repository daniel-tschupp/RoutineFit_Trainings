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
    public void Training_MoqFramework_SetupMockForMethodWithReturnValue()
    {
        int expectedReturnValue = 6;
        var returnedValue = 0;

        MoqTestReturnValue(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnValue(int expectedArgumentValue, int returnedValue)
    {
        Assert.IsTrue(false, "Implement the Moq Framework to check if the method was called once and it returned the expected value.");
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
        int expectedReturnValue = 6;
        var returnedValue = 0;
        _testMock.Setup(x => x.MethodWithReturn()).Returns(expectedReturnValue);
        returnedValue = _testMock.Object.MethodWithReturn();

        MoqTestReturnValue_Solution(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnValue_Solution(int expectedArgumentValue, int returnedValue)
    {
        _testMock.Verify(x => x.MethodWithReturn(), Times.Once);
        Assert.AreEqual(expectedArgumentValue, returnedValue);
    }
}
