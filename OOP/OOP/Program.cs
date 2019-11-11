using Microsoft.Extensions.DependencyInjection;
using OOP.Samples.AbstractizationSamples;
using OOP.Samples.InheritanceSamples;
using OOP.Samples.InterfaceSamples;
using OOP.Samples.InterfaceSamples.Domain;
using OOP.Samples.PolymorphismSamples;
using System;

namespace OOP
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            //ChainingConstructorsExample();

            //MultilevelInheritanceExample();

            //InheritanceInterfaceExample();

            //InheritanceInjectedExample();

            CompileTimePolymorphismExample();

            RunTimPolymorphismExample();

            AbstractExample();

            SealedExample();
        }

        private static void ChainingConstructorsExample()
        {
            var chaningConstructors = new ChainingConstructors();
            chaningConstructors.Run();

            Console.ReadKey();
        }

        private static void MultilevelInheritanceExample()
        {
            var multiLevelInheritance = new MultilevelInheritance();
            multiLevelInheritance.Run();

            Console.ReadKey();
        }

        private static void InheritanceInterfaceExample()
        {
            var student = new CreateStudentService()
                .Handle("Jon", "Snow", "jon.snow@gmail.com", "075698565", Guid.NewGuid());

            Console.WriteLine(student);
            Console.ReadKey();
        }

        private static void InheritanceInjectedExample()
        {
            ConfigDependencyInjection();

            RunInheritanceInjectedExample();
        }

        private static void ConfigDependencyInjection()
        {
            _serviceProvider = new ServiceCollection()
                .AddScoped<IStudentCreate, CreateStudentService>()
                .BuildServiceProvider();
        }

        private static void RunInheritanceInjectedExample()
        {
            var studentCreateProvider = _serviceProvider.GetService<IStudentCreate>();
            var student = studentCreateProvider.Handle("Jon", "Snow", "jon.snow@gmail.com", "0254588852", Guid.NewGuid());

            Console.WriteLine(student);
            Console.ReadKey();
        }

        private static void CompileTimePolymorphismExample()
        {
            var methodOverloading = new CompileTimePolymorphism();

            Console.WriteLine("Sum of 1 + 2 = ");
            Console.WriteLine(methodOverloading.Add(1, 2));

            Console.WriteLine("Sum of 1 + 2 + 3 = ");
            Console.WriteLine(methodOverloading.Add(1, 2, 3));

            Console.WriteLine("Sum of 1 + 2 + 3 + 4 = ");
            Console.WriteLine(methodOverloading.Add(1, 2, 3, 4));

            Console.WriteLine("Sum of 1 + 2 + 3 + 4 + 5 =");
            Console.WriteLine(methodOverloading.Add(1, 2, 3, 4, 5));

            Console.ReadKey();
        }

        private static void RunTimPolymorphismExample()
        {
            var runtime = new RunTimePolymorphism();
            runtime.Run();

            Console.ReadKey();
        }

        private static void AbstractExample()
        {
            var abstractUseCase = new AbstractUseCase();
            abstractUseCase.Run();

            Console.ReadKey();
        }

        private static void SealedExample()
        {
            var sealedUseCase = new SealedUseCase();
            sealedUseCase.Run();

            Console.ReadKey();
        }
    }
}
