using Moq;

namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{
    public interface ITest
    {
        void MethodWithArgument(int myProperty);
    }

    [TestMethod]
    public void Traning_MoqFramework_SetupMethodWithArgument()
    {
        int expectedArgumentValue = 6;

        MoqTestIfPropertyIsSet(expectedArgumentValue);
    }

    private void MoqTestIfPropertyIsSet(int expectedArgumentValue)
    {
        Assert.IsTrue(false, "Implement the Moq Framework to check if the method was called once and with correct argument.");
    }

    [TestMethod]
    public void VerifySolution() => this.Solution();
}































public partial class TrainingSpace
{
    private Mock<ITest> _solutionMock = new Mock<ITest>();

    private void Solution()
    {
        int expectedArgumentValue = 6;
        _solutionMock.Object.MethodWithArgument(expectedArgumentValue);
        MoqTestIfPropertyIsSet_Solution(expectedArgumentValue);
    }
    private void MoqTestIfPropertyIsSet_Solution(int expectedArgumentValue)
    {
        _solutionMock.Verify(x => x.MethodWithArgument(expectedArgumentValue), Times.Once);
    }
}
