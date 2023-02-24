using System.Reflection;

namespace ReflectionBatchDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reflection Demo");
           //type represent declared type of class,interface type,array type
            Type type = Type.GetType("ReflectionBatchDemo.Employee");
            Console.WriteLine(type.FullName); //namespace+classname
            Console.WriteLine(type.Name);  //classname

            Console.WriteLine("-------Constructor--------");
            ConstructorInfo[] constructor = type.GetConstructors();
            foreach(ConstructorInfo constructorName in constructor)
            {
                Console.WriteLine(constructorName.IsSpecialName);
                Console.WriteLine(constructorName.Name);
                Console.WriteLine(constructorName.ToString());

            }

            Console.WriteLine("-------Method-------");
            MethodInfo[] methodName = type.GetMethods();
            foreach (MethodInfo method in methodName)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name );
            }

            Console.WriteLine("-------Property--------");
            PropertyInfo[] propertyName = type.GetProperties();
            foreach(PropertyInfo property in propertyName)
            {
                Console.WriteLine(property.ReflectedType.Name+" "+property.Name);
            }

        }
    }
}