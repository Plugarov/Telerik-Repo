namespace High.Quality.Code.BadExample
{
    using System;

    [Serializable]
    public class Bunny
    {
        private const string MessageToAppendBunnyName = "Bunny name: {0}";
        private const string MessageToAppendBunnyAge = "Bunny age: {0}";
        private const string MessageToAppendBunnyFur = "Bunny fur: {0}";

        private const string PrintBunnyIntroduction = "{0} - \"I am {1} years old!";
        private const string PrintBunnyFurInformation = "{0} - \"And I am {1}";

        public int Age { get; set; }
        public string Name { get; set; }
        public FurType FurType { get; set; }

        public void Introduce(IWriter writer)
        {
            writer.WriteLine(PrintBunnyIntroduction, this.Name, this.Age);
            writer.WriteLine(PrintBunnyFurInformation, this.Name, this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter());
        }

        public override string ToString()
        {
            var builderSize = 200;

            var builder = new StringBuilder(builderSize);

            builder.AppendLine(string.Format(MessageToAppendBunnyName, this.Name));
            builder.AppendLine(string.Format(MessageToAppendBunnyAge, this.Age));
            builder.AppendLine(string.Format(MessageToAppendBunnyFur, this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()));

            return builder.ToString();
        }
    }
}