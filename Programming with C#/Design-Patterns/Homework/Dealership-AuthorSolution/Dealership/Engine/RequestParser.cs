using Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dealership.Engine
{
    public class RequestParser : IRequestParser
    {
        private const char SplitCommandSymbol = ' ';
        private const string CommentOpenSymbol = "{{";
        private const string CommentCloseSymbol = "}}";

        private string name;
        private List<string> parameters;

        public RequestParser(string input)
        {
            this.Parameters = new List<string>();
            this.Parse(input);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public List<string> Parameters
        {
            get
            {
                return this.parameters;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of strings cannot be null.");
                }

                this.parameters = value;
            }
        }

        private void Parse(string input)
        {
            var indexOfFirstSeparator = input.IndexOf(SplitCommandSymbol);
            var indexOfOpenComment = input.IndexOf(CommentOpenSymbol);
            var indexOfCloseComment = input.IndexOf(CommentCloseSymbol);
            Regex regex = new Regex("{{.+(?=}})}}");

            if (indexOfFirstSeparator < 0)
            {
                this.Name = input;
                return;
            }

            this.Name = input.Substring(0, indexOfFirstSeparator);

            if (indexOfOpenComment >= 0)
            {
                this.Parameters.Add(input.Substring(indexOfOpenComment + CommentOpenSymbol.Length, indexOfCloseComment - CommentCloseSymbol.Length - indexOfOpenComment));
                input = regex.Replace(input, string.Empty);
            }

            this.Parameters.AddRange(input.Substring(indexOfFirstSeparator + 1).Split(new[] { SplitCommandSymbol }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
