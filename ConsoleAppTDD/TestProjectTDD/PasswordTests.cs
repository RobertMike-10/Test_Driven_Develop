using ConsoleAppTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace TestProjectTDD
{
    public class PasswordTests
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(7) +"A";
            var validation = target.Validate(password);
            Assert.True(validation);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(6) +"A";
            var validation = target.Validate(password);
            Assert.False(validation);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(8);
            var validation = target.Validate(password);
            Assert.False(validation);
        }

        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var target = new DefaultPasswordValidator();
            var password = MakeString(7) +"A";
            var validation = target.Validate(password);
            Assert.True(validation);
        }

        private string MakeString(int lenght)
        {
            string result = "";
            for(int i=1;i<=lenght;i++)
            {
                result += "a";
            }
            return result;
        }
    }
}
