namespace EvaluationSampleCode.UnitsTest;

[TestClass]
public class ReservationTests
{
    [TestMethod]
    public void CanBeCancelledByUserIsAdminReturnsTrue()
    {
        // Arrange
        var adminUser = new User { IsAdmin = true };
        var reservation = new Reservation(new User());

        // Act
        var result = reservation.CanBeCancelledBy(adminUser);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_UserMadeTheReservation_ReturnsTrue()
    {
        // Arrange
        var user = new User();
        var reservation = new Reservation(user);

        // Act
        var result = reservation.CanBeCancelledBy(user);

        // Assert
        Assert.IsTrue(result);
    }
}
