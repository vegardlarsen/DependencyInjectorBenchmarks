﻿using System;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace DependencyInjectorBenchmarks.Containers
{
    public class MefBenchmark : IContainerBenchmark
    {
        public static readonly MefBenchmark Instance = new MefBenchmark();

        private readonly CompositionContainer mefContainer = new CompositionContainer(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

        public IStatelessStorage ResolveSingleton() => mefContainer.GetExportedValue<IStatelessStorage>();

        public IStatefulStorage ResolveTransient() => mefContainer.GetExportedValue<IStatefulStorage>();
    }
}