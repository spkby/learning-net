namespace Convertor
{
    interface IConvertible
    {
        string ConvertToCSharp(string str);
        string ConvertToVB(string str);
    }
}
