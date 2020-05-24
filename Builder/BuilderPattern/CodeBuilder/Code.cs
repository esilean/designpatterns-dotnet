using System;
namespace DesignPatterns.BuilderPattern.CodeBuilder
{
    public class Code
    {
        public string field { get; }
        public string fieldType { get; }
        public Code(string field, string fieldType)
        {
            this.field = field;
            this.fieldType = fieldType;
        }
    }
}
