using ExceptionsLesson10;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]

        public void Test1()
        {
            var result = UserRegistrationService.UserValidator("ArturTes");
            Assert.False(result);
        
        }
    }
}