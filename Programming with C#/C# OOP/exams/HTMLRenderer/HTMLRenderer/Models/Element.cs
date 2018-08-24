namespace HTMLRenderer.Models
{
    using HTMLRenderer.Interfaces;
    using System.Text;

    public class Element : BaseElement, IElement
    {
        public Element(string name)
            : base()
        {
            this.name = name;
        }

        public Element(string name, string textContent)
            : base()
        {
            this.name = name;
            this.TextContent = textContent;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual void Render(StringBuilder output)
        {

        }

        public override string ToString()
        {
            string toRender = "";

            if (!string.IsNullOrEmpty(this.name))
            {
                toRender += $"<{this.name}>";
            }

            if (!string.IsNullOrEmpty(this.TextContent))
            {
                toRender += string.Format("{0}", HTMLEscape(this.TextContent));
            }

            toRender += string.Join("", this.ChildElements);

            if (!string.IsNullOrEmpty(this.name))
            {
                toRender += $"</{this.name}>";
            }

            return toRender;
        }

        private string HTMLEscape(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                content = content
                    .Replace("&", "&amp;")
                    .Replace("<", "&lt;")
                    .Replace(">", "&gt;");
            }

            return content;
        }
    }
}
