namespace HTMLRenderer.Models
{
    using System.Collections.Generic;
    using HTMLRenderer.Interfaces;

    public abstract class BaseElement
    {
        protected string name;
        private IList<IElement> childElements;
        private string textContent;

        public BaseElement()
        {
            this.childElements = new List<IElement>();
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }
    }
}
