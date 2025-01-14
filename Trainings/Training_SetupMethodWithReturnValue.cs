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
    public void Training_SetupMockPropertySetter()
    {
        // Use Moq Framework to setup a mock object for the ITest Interface Property Setter that sets pValue.
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
        _testMock.Object.MyProperty = pValue;
        _testMock.VerifySet(x => x.MyProperty = pValue, Times.Once);
    }
}
