namespace Common
{
    public class TypeA
    {
        public TypeA() {
            TypeB typeB = new TypeB();
        }
       private int x; // Class Scope only
       internal int y; // Class Scope and it's projects
       public int z; //

        void Print ()
        {
            Console.WriteLine(x);
        }
    }
}
