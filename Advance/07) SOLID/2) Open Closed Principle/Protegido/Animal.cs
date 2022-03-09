namespace Protegido
{
    public abstract class Animal
    {
        public abstract void Eat();

        /// <summary>
        /// Keyword protected is useful when you want your class and all
        /// derived (child) classes to be able to access the method or variable
        /// but you don't want it to be public.
        /// </summary>
        protected abstract void ComplexMoving();

        public void Move()
        {
            ComplexMoving();
        }
    }
}
