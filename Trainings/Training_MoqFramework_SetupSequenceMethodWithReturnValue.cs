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
    public void Training_MoqFramework_SetupSequenceMethodWithReturnValue()
    {
        var expectedReturnValue = new List<int>() { 1, 2, 3, 4 }; ;
        var returnedValue = new List<int>();

        MoqTestReturnsMultipleValues(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnsMultipleValues(List<int> expectedArgumentValue, List<int> returnedValue)
    {
        Assert.IsTrue(false, "Implement the Moq Framework to check if the method was called " +
            "multiple times and it returned all the expected values.");
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
        var expectedReturnValue = new List<int>() { 1, 2, 3, 4 }; ;
        var returnedValue = new List<int>();

        var sequence = _testMock.SetupSequence(x => x.MethodWithReturn());
        expectedReturnValue.ForEach(v => sequence.Returns(v));

        Enumerable.Range(0, expectedReturnValue.Count)
            .ToList()
            .ForEach(idx => returnedValue.Add(_testMock.Object.MethodWithReturn())
        );

        MoqTestReturnsMultipleValues_Solution(expectedReturnValue, returnedValue);
    }
    private void MoqTestReturnsMultipleValues_Solution(List<int> expectedArgumentValue, List<int> returnedValue)
    {
        expectedArgumentValue
            .Zip(returnedValue, (expValue, retValue) => new { expValue, retValue })
            .ToList()
            .ForEach(pair => Assert.AreEqual(pair.expValue, pair.retValue));

        _testMock.Verify(x => x.MethodWithReturn(), Times.Exactly(expectedArgumentValue.Count));
    }
}
