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
    [TestMethod]
    public void VerifySolution() => this.Solution();
}































public partial class TrainingSpace
{
    private Mock<ITest> _solutionMock = new Mock<ITest>();

    private void Solution()
    {
        int expectedReturnValue = 6;
        var returnedValue = 0;
        _solutionMock.Setup(x => x.MethodWithReturn()).Returns(expectedReturnValue);
        returnedValue = _solutionMock.Object.MethodWithReturn();

        MoqTestReturnValue_Solution(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnValue_Solution(int expectedArgumentValue, int returnedValue)
    {
        _solutionMock.Verify(x => x.MethodWithReturn(), Times.Once);
        Assert.AreEqual(expectedArgumentValue, returnedValue);
    }
}
