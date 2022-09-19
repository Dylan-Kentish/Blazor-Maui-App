namespace RazorClassLibrary1
{
    /// <summary>
    /// Temporary solution from https://stackoverflow.com/questions/11214138/get-assembly-reference-without-reflection-or-a-known-type
    /// </summary>
    public static class AssemblyReference
    {
        public static System.Reflection.Assembly Get
        {
            get
            {
                return typeof(AssemblyReference).Assembly;
            }
        }
    }
}
