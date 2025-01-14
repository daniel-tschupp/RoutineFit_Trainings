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
    public void Traning_SetupMethodWithArgument()
    {
        // Use Moq Framework to setup a mock object for the ITest Interface Property SetProperty that sets pValue.
        // Verify the setted value. Also verify that the Property was called only once.
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
    private void Solution()
    {
        int pValue = 6;

        _testMock.Object.MethodWithArgument(pValue);
        _testMock.Verify(x => x.MethodWithArgument(pValue), Times.Once);
    }
}
