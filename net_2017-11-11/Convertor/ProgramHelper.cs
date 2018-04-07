namespace Convertor
{
    public class ProgramHelper : ProgramConverter, IСodeChecker
    {
        public bool CodeCheckSyntax(string str1, string str2)
        {
            return str1.Equals(str2);
        }

        public override string ConvertToCSharp(string str)
        {
            return str + " PH+C#";
        }

        public override string ConvertToVB(string str)
        {
            return str + " PH-V#";
        }
    }
}
