using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
                BenchmarkRunner.Run(typeof(Program).Assembly);
            else
                BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());
        }
    }
}
