using System;


namespace Abstraction
{
    public abstract class AbstractClass //Base
    {
        public AbstractClass(string name)
        {
            _name = name;
        }
        private string _name;
        //private abstract string Name; //Field error
        public abstract int PI { get; set; }
        public virtual int Prop { get; set; }

        public abstract string Method();

        public virtual int GetYear()
        {
            return DateTime.Now.Year;
        }
        public double GetE()
        {
            return Math.E;
        }
        public string GetName()
        {
            return _name;
        }
    }

    public class ConcreteClass : AbstractClass
    {
        public ConcreteClass(string name) : base(name)
        {

        }

        public override int PI
        {
            get
            {
                return (int)Math.PI;
            }
            set { }
        }
        public override string Method()
        {
            return "";
        }
    }
    public abstract class AbstractApple
    {
        private string type;
        private string color;

        public AbstractApple(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        public string GetAppleType()
        {
            return type;
        }

        public string GetColor()
        {
            return color;
        }
    }

    public class GoldenApple : AbstractApple
    {
        public GoldenApple(string type, string color) : base(type, color)
        {
        }
        public int MyProperty { get; set; }
    }

    public class DemirApple : AbstractApple
    {
        public DemirApple(string type, string color) : base(type, color)
        {
        }
    }

    public class NorTarvaSexaniApple : AbstractApple
    {
        public NorTarvaSexaniApple(string type, string color) : base(type, color)
        {
        }
    }
}
