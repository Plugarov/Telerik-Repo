using System.Text;

using My.Blog.Web.Helpers.Contracts;

namespace My.Blog.Web.Helpers
{
    public class BlogUrlGenerator : IBlogUrlGenerator
    {
        public string GenerateUrl(int id, string title)
        {
            return string.Format("/blog/{0}/{1}", id, this.ToUrl(title));
        }

        public string ToUrl(string uglyString)
        {
            var resultString = new StringBuilder(uglyString.Length);
            bool isLastCharacterDash = false;

            uglyString = uglyString.Replace("C#", "CSharp");
            uglyString = uglyString.Replace("C++", "CPlusPlus");

            foreach (var character in uglyString)
            {
                if (char.IsLetterOrDigit(character))
                {
                    resultString.Append(character);
                    isLastCharacterDash = false;
                }
                else if (!isLastCharacterDash)
                {
                    resultString.Append('-');
                    isLastCharacterDash = true;
                }
            }

            return resultString.ToString().Trim('-');
        }
    }
}