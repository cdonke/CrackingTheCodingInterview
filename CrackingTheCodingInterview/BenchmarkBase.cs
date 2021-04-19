using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CrackingTheCodingInterview
{
    [MemoryDiagnoser]
    [MarkdownExporterAttribute.GitHub]
    [KeepBenchmarkFiles]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    public abstract class BenchmarkBase
    {       
    }
}
