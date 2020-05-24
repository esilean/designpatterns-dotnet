using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.CodeBuilder
{

    public class CodeBuilder
    {
        private string className;
        private List<Code> codes = new List<Code>();

        public CodeBuilder(string className)
        {
            this.className = className;
        }

        public CodeBuilder AddField(string field, string fieldType)
        {
            this.codes.Add(new Code(field, fieldType));
            return this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"public class {this.className}");
            sb.AppendLine("{");
            foreach (var code in this.codes)
            {
                sb.AppendLine($"  public {code.fieldType} {code.field};");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

    }
}
