namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{
    List<int> _expectedValues = new() {  1, 3, 5 };
    [TestMethod]
    public void Training_MsTest_MultiRunWithDifferentData()
    {
        var indexOfExpectedValue = 0;
        var valueToCheck = 0;
        var expectedValue = _expectedValues[indexOfExpectedValue];

        CheckData(expectedValue, valueToCheck);
    }

    private void CheckData(int expectedValue, int valueToCheck)
    {
        Assert.AreEqual(expectedValue, valueToCheck);
    }
}

















































public partial class TrainingSpace
{
    [TestMethod]
    [DataRow(0, 1)]
    [DataRow(1, 3)]
    [DataRow(2, 5)]
    public void Solution(int index, int value)
    {
        var indexOfExpectedValue = index;
        var valueToCheck = value;
        var expectedValue = _expectedValues[indexOfExpectedValue];

        CheckData(expectedValue, valueToCheck);
    }
}
