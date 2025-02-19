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
}































public partial class TrainingSpace
{
    private Mock<ITest> _solutionMock = new Mock<ITest>();
    
    private void Solution()
    {
        int expectedReturnValue = 6;
        var returnedValue = 0; 

        _solutionMock.SetupGet(x => x.MyProperty).Returns(expectedReturnValue);
        returnedValue = _solutionMock.Object.MyProperty;
        MoqTestReturnPropertyValue_Solution(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnPropertyValue_Solution(int expectedArgumentValue, int returnedValue)
    {
        Assert.AreEqual(expectedArgumentValue, returnedValue);
        _solutionMock.VerifyGet(x => x.MyProperty, Times.Once);
    }
}
