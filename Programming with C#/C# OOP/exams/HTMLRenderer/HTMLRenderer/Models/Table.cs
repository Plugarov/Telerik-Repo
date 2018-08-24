namespace HTMLRenderer.Models
{
    using System;
    using System.Text;
    using HTMLRenderer.Interfaces;

    public class Table : Element, IElement, ITable
    {
        private IElement[,] matrix;

        public Table(int rows, int cols)
            : base("table")
        {
            this.matrix = new IElement[rows, cols];
        }

        public IElement this[int row, int col]
        {
            get => this;
            set { this.matrix[row, col] = value; }
        }

        public int Rows
        {
            get { return this.Rows; }
        }

        public int Cols
        {
            get { return this.Cols; }
        }

        public override string ToString()
        {
            string toRender = $"<{this.name}>";

            if (!string.IsNullOrEmpty(this.TextContent))
            {
                toRender += string.Format("{0}", this.TextContent);
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                toRender += "<tr>";
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    toRender += string.Format($"<td>{matrix[rows, cols]}</td>");
                }
                toRender += "</tr>";
            }

            toRender += $"</{this.name}>";

            return toRender;
        }
    }
}
