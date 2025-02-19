namespace Trainingsplatform;

[TestClass]
public partial class TrainingSpace
{

    [TestMethod]
    public void Training_MsTest_SkipThisTest()
    {
        Assert.IsTrue(false, "Skip this test!");
    }

    public void VerifySolution() => this.SkipSolution();
}














































public partial class TrainingSpace
{
    [TestMethod]
    [Ignore("This test is temporarily disabled.")]
    public void SkipSolution()
    {
        Assert.IsTrue(false, "Skip this test!");
    }
}
