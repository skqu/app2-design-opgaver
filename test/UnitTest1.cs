using NSBulb;
namespace test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void WhiteBulb_StateChange_On()
    {
        // Arrange
        White whiteBulb = new White();

        // Act
        whiteBulb.ChangeState(1);
        whiteBulb.Execute();

        // Assert
        Assert.AreEqual(1, whiteBulb.CurrentState());
    }

    [TestMethod]
    public void WhiteBulb_StateChange_Off()
    {
	// Arrange
	White whiteBulb = new White();

	//Act
	whiteBulb.ChangeState(2);
	whiteBulb.Execute();

	//Assert
	Assert.AreEqual(2, whiteBulb.CurrentState());
    }

    [TestMethod]
    public void WhiteBulb_StateChange_Idle()
    {
	// Arrange
	White whiteBulb = new White();

	// Act
	whiteBulb.ChangeState(0);
	whiteBulb.Execute();

	// Assert
	Assert.AreEqual(0, whiteBulb.CurrentState());
    }

    [TestMethod]
    public void WhiteBulb_StateChange_Unknown()
    {
	// Arrange
	White whiteBulb = new White();

	// Act
	whiteBulb.ChangeState(5);
	whiteBulb.Execute();

	// Assert
	Assert.AreEqual(-1, whiteBulb.CurrentState(), "Unknown state/not valid state should return 0");
    }

    [TestMethod]
    public void ColorBulb_StateChange_On()
    {
	// Arrange
	Color bulb = new Color();

	// Act
	bulb.ChangeState(1);
	bulb.Execute();

	// Assert
	Asser.AreEqual(1, bulb.CurrentState());
    }

    [TestMethod]
    public void ColorBulb_StateChange_Off()
    {
        // Arrange
        Color bulb = new Color();

        // Act
        bulb.ChangeState(2);
        bulb.Execute();

        // Assert
        Assert.AreEqual(2, bulb.CurrentState());
    }

    [TestMethod]
    public void ColorBulb_StateChange_Red()
    {
        // Arrange
        Color bulb = new Color();

        // Act
        bulb.ChangeState(3);
        bulb.Execute();

        // Assert
        Assert.AreEqual(3, bulb.CurrentState());

    }

    [TestMethod]
    public void ColorBulb_StateChange_Green()
    {
        // Arrange
        Color bulb = new Color();

        // Act
        bulb.ChangeState(4);
        bulb.Execute();

        // Assert
        Assert.AreEqual(4, bulb.CurrentState());
    }

    [TestMethod]
    public void ColorBulb_StateChange_Blue()
    {
        // Arrange
        Color bulb = new Color();

        // Act
        bulb.ChangeState(5);
        bulb.Execute();

        // Assert
        Assert.AreEqual(5, bulb.CurrentState());
    }

    [TestMethod]
    public void ColorBulb_StateChange_Unknown()
    {
        // Arrange
        Color bulb = new Color();

        // Act
        bulb.ChangeState(6);
        bulb.Execute();

        // Assert
        Assert.AreEqual(-1, bulb.CurrentState());
    }
}
