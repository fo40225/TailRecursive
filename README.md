# TailRecursive
.net tail recursive optimization

C# will do a limited tail call optimization on CLR(JIT) level, no compiler optimization.

F# compiler can generate OpCodes.Tailcall.

Run the release build without debugger and attach debugger to observe the call stack.
