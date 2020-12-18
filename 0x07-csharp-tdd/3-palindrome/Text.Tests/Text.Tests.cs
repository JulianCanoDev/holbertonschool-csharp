using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class Tests
    {

        [Test]
        public void Test_Palindrome_01()
        {
            Assert.AreEqual(true, Str.IsPalindrome(""));
        }
        public void Test_Palindrome_02()
        {
            Assert.AreEqual(true, Str.IsPalindrome("reconocer"));
        }
        public void Test_Palindrome_03()
        {
            Assert.AreEqual(false, Str.IsPalindrome("hello"));
        }
        public void Test_Palindrome_04()
        {
            Assert.AreEqual(true, Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
        public void Test_Palindrome_05()
        {
            Assert.AreEqual(true, Str.IsPalindrome("Desserts, I stressed"));
        }
        public void Test_Palindrome_06()
        {
            Assert.AreEqual(true, Str.IsPalindrome("Red rum, sir, is murder"));
        }
    }
}