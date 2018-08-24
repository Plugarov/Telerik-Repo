using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2.SimpleFactory
{
    class SimpleFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.CeilingFan:
                    return new CeilingFan();
                case FanType.ExhaustFan:
                    return new ExhaustFan();
                default:
                    return new TableFan();
            }
        }
    }

    enum FanType
    {
        TableFan,
        CeilingFan,
        ExhaustFan,
    }

    internal class ExhaustFan : IFan
    {
    }

    internal class CeilingFan : IFan
    {
    }

    internal class TableFan : IFan
    {
    }

    public interface IFan
    {
    }

    internal interface IFanFactory
    {
    }
}
