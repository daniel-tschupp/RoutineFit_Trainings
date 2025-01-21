namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{

    [TestMethod]
    public void Training_Dictionary_InititializeDictionaryWithNameAgePairs()
    {
        Dictionary<string, int> nameAgePairs = null;

        VerifyNameAgeDictionary(nameAgePairs);
    }
    private void VerifyNameAgeDictionary(Dictionary<string, int> nameAgePairs)
    {
        Assert.AreEqual(nameAgePairs["Jon"], 11);
        Assert.AreEqual(nameAgePairs["Max"], 44);
        Assert.AreEqual(nameAgePairs["Peter"], 66);
    }
    [TestMethod]
    public void VerifySolution() => this.Solution();
}































public partial class TrainingSpace
{
    private void Solution()
    {
        Dictionary<string, int> nameAgePair = new()
        {
            ["Jon"] = 11,
            ["Max"] = 44,
            ["Peter"] = 66
        };
        VerifyNameAgeDictionary(nameAgePair);
    }
}
