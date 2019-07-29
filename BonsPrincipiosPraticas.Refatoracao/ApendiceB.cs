using System.Collections.Generic;

namespace BonsPrincipiosPraticas.Refatoracao.ApendiceB
{
    internal class HoldprintBooleanContent : FieldContent
    {
        private bool v;

        public HoldprintBooleanContent(bool v)
        {
            this.v = v;
        }
    }

    internal class HoldprintNumberContent : FieldContent
    {
        private int v;

        public HoldprintNumberContent(int v)
        {
            this.v = v;
        }
    }

    internal class HoldprintFeedstockFilterContent : FieldContent
    {
    }

    internal class HoldprintTextContent : FieldContent
    {
        private string empty;

        public HoldprintTextContent(string empty)
        {
            this.empty = empty;
        }
    }

    internal class HoldprintDateIntervalContent : FieldContent
    {
    }

    internal class HoldprintDateContent : FieldContent
    {
    }

    internal class HoldprintIntervalTimeContent : FieldContent
    {
        private string empty;

        public HoldprintIntervalTimeContent(string empty)
        {
            this.empty = empty;
        }
    }

    internal class HoldprintTimeContent : FieldContent
    {
        private string empty;

        public HoldprintTimeContent(string empty)
        {
            this.empty = empty;
        }
    }

    internal class HoldprintArrayContent : FieldContent
    {
        private List<string> list;

        public HoldprintArrayContent(List<string> list)
        {
            this.list = list;
        }
    }

    public class FieldContent
    {
    }

    public enum FieldContentType
    {
        Texto = 1,
        AutoComplete = 2,
        LongText = 3,
        Numbers = 4,
        Currency = 5,
        CheckboxOptions = 6,
        RadioOptions = 7,
        User = 8,
        Enterprise = 9,
        Person = 10,
        Phone = 11,
        Time = 12,
        IntervalTime = 13,
        Date = 14,
        IntervalDate = 15,
        Address = 16,
        SwitchButton = 17,
        FeedstockFilter = 19,
        InkSelector = 20,
        QquipmentsOptions = 21,
        InkTypeSelector = 22,
        SupplierList = 23,
        BillingConfig = 24,
        PriceConfig = 25
    }

    public interface IHoldprintContentFactory
    {
        FieldContent GetByType(FieldContentType fieldContentType);
    }

    public class HoldprintContentFactory
    {
        public FieldContent GetByType(FieldContentType fieldContentType)
        {
            switch (fieldContentType)
            {
                case FieldContentType.AutoComplete:
                case FieldContentType.CheckboxOptions:
                    return new HoldprintArrayContent(new List<string>());
                case FieldContentType.Time:
                    return new HoldprintTimeContent(string.Empty);
                case FieldContentType.IntervalTime:
                    return new HoldprintIntervalTimeContent(string.Empty);
                case FieldContentType.Date:
                    return new HoldprintDateContent();
                case FieldContentType.IntervalDate:
                    return new HoldprintDateIntervalContent();
                case FieldContentType.FeedstockFilter:
                    return new HoldprintFeedstockFilterContent();
                case FieldContentType.InkTypeSelector:
                    return new HoldprintNumberContent(0);
                case FieldContentType.SwitchButton:
                    return new HoldprintBooleanContent(false);
                default:
                    return new HoldprintTextContent(string.Empty);
            }
        }
    }

    public class FieldService
    {
        private readonly IHoldprintContentFactory holdprintContentFactory;

        public FieldService(IHoldprintContentFactory holdprintContentFactory)
        {
            // Princípio da inversão de dependência: depender de uma abstração
            // e não de uma classe concreta.
            this.holdprintContentFactory = holdprintContentFactory;
        }

        private FieldContent GetByType(FieldContentType fieldContentType)
        {
            // Delega a criação do objeto FieldContent a uma classe especializada,
            // aprimorando a manutenção com o reuso e mantendo a lógica de criação em
            // um único local.
            return holdprintContentFactory.GetByType(fieldContentType);
        }
    }
}
