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
        int expectedArgumentValue = 6;
        _testMock.Object.MethodWithArgument(expectedArgumentValue);
        MoqTestIfPropertyIsSet_Solution(expectedArgumentValue);
    }
    private void MoqTestIfPropertyIsSet_Solution(int expectedArgumentValue)
    {
        _testMock.Verify(x => x.MethodWithArgument(expectedArgumentValue), Times.Once);
    }
}
