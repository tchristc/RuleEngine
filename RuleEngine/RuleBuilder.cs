using System.Collections.Generic;
using System.Linq;

namespace RuleEngine
{
    public class Token
    {
        protected string _value;
        public string Value { get { return _value; } }

        public Token(string value)
        {
            _value = value;
        }
    }

    public class Operand : Token
    {
        public Operand(string value) 
            :base(value)
        {
        }
    }

    public class Operation : Token
    {
        public Operation(string value)
            : base(value)
        {
        }
    }

    public class BinaryRule
    {
        public Operand LeftHand { get; set; }
        public Operand RightHand { get; set; }
        public Operation Operation { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", LeftHand, Operation, RightHand);
        }
    }

    public interface IProvider<T, R>
        where T : class 
    {
        R Provide<T>();
    }

    public class MemberProvider<T> 
        : IProvider<T, List<string>>
        where T : class
    {
        public List<string> Provide<T>()
        {
            return typeof(T)
                .GetMembers()
                .Select(m=>m.Name)
                .ToList();
        }
    }

    public class PropertyProvider<T> 
        : IProvider<T, List<string>>
        where T : class
    {
        public List<string> Provide<T>()
        {
            return typeof(T)
                .GetProperties()
                .Select(m => m.Name)
                .ToList();
        }
    }

    public class RuleBuilder<T>
    {

    }
}
