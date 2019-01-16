Many personal computers and workstations have multiple CPU cores that enable multiple threads to be executed simultaneously. To take advantage of the hardware, you can parallelize your code to distribute work across multiple processors.

In the past, parallelization required low-level manipulation of threads and locks. Visual Studio and the .NET Framework enhance support for parallel programming by providing a runtime, class library types, and diagnostic tools. These features, which were introduced with the .NET Framework 4, simplify parallel development. You can write efficient, fine-grained, and scalable parallel code in a natural idiom without having to work directly with threads or the thread pool.

The following illustration provides a high-level overview of the parallel programming architecture in the .NET Framework:

<p align='center'><img src='https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/media/tpl-architecture.png'></p>
