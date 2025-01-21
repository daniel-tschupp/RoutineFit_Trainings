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
    public void Training_MoqFramework_SetupMockPropertySetter()
    {
        int Expected_MyProperty = 6;

        MoqTestIfPropertyIsSet(Expected_MyProperty);
    }

    private void MoqTestIfPropertyIsSet(int expectedPropertyValue)
    {
        Assert.IsTrue(false, "Implement the Moq Framework to check if the property was set once and with correct value.");
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
        int Expected_MyProperty = 6;
        _testMock.Object.MyProperty = Expected_MyProperty;
        MoqTestIfPropertyIsSet_Solution(Expected_MyProperty);
    }
    private void MoqTestIfPropertyIsSet_Solution(int expectedPropertyValue)
    {
        _testMock.VerifySet(x => x.MyProperty = expectedPropertyValue, Times.Once);
    }
}
