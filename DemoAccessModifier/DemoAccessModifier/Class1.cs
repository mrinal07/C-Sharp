namespace DemoAccessModifier
{
    public class Class1
    {
        private int l = 99;
        public int m = 88;
        protected int n = 77;
        internal int o = 66;
        protected internal int q = 55;

        public override string ToString()
        {
            return l+" "+m+" "+n+" "+o+" "+q ;
        }
    }

    
}