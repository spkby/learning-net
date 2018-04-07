
namespace Convertor
{
    public class ProgramConverter : IConvertible
    {
        public virtual string ConvertToCSharp(string str)
        {
            return str + " PC-C#";
        }

        public virtual string ConvertToVB(string str)
        {
            return str + " PC-V#";
        }
    }
}
