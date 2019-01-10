How an object ends up on the large object heap and how GC handles them.

In .NET 1.1 and 2.0 if an object is >= 85,000 bytes it’s considered a large object. This number was determined by performance tuning. When an object allocation request comes in, if it’s >= 85,000 bytes, we will allocate it on the large object heap. What does this mean exactly? To understand this, it may be beneficial to explain some fundamentals about the .NET GC.

As many of you are aware, the .NET Garbage Collect is a generational collector. It has 3 generations – generation 0, generation 1 and generation 2. The reason behind having 3 generations is that we expect for a well tuned app, most objects die in Gen0. For example, in a server app, the allocations associated each request should die after the request is finished. And the in flight allocation requests will make into Gen1 and die there. Essentially Gen1 acts as a buffer between young object areas and long lived object areas.

From the generation point of view, large objects belong to generation 2 because they are collected only when we do a generation 2 collection.

When a generation gets collected, all its younger generation(s) also get collected. So for example, when a generation 1 GC happens, both generation 1 and 0 get collected. And when a generation 2 GC happens, the whole heap gets collected. For this reason a generation 2 GC is also called a full GC. In this article I will use generation 2 GC instead of full GC but they are interchangeable.

So generations are the logical view of the GC heap. Physically, objects live on the managed heap segments. A managed heap segment is a chunk of memory that the GC reserves from the OS (via calling VirtualAlloc) on behalf of managed code. When the CLR gets loaded we allocate 2 initial heap segments – one for small objects and one for large objects which we will refer to as SOH (Small Object Heap) and LOH (Large Object Heap) respectively.

The allocation requests are then satisfied by putting managed objects on this managed heap segment. If the object is less than 85,000 byte it will be put on the segment for SOH; otherwise it’ll be on a LOH segment. Segments are committed (in smaller chunks) as more and more objects are allocated onto them.

For SOH, objects that survive a GC get promoted to the next generation; so objects that survive a generation 0 collection will now be considered generation 1 objects, and so on. Objects that survive the oldest generation, however, will still be considered in the oldest generation. In other words, survivors from generation 2 will be generation 2 objects; and survivors from LOH will be LOH objects (collected with gen2). The user code can only allocate in generation 0 (small objects) or LOH (large objects). Only GC can “allocate” objects in generation 1 (by promoting survivors from generation 0) and generation 2 (by promoting survivors from generation 1 and 2).

When a GC is triggered, we trace through the live objects and compact them. For LOH though, because compaction is expensive we choose to sweep them, meaning making a free list out of dead objects that can be reused later to satisfy large object allocation requests. Adjacent dead objects are made into one free object.

An important thing to keep in mind is that even though today we don’t compact LOH, we might in the future. So if you allocate large objects and want to make sure that they don’t move you should still pin them.

Note that the figures below are only for illustration purposes – I use very few objects to show what happens on the heap. In reality there are much more objects there.
