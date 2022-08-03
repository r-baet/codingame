open System
open OutputGenerator

let r1 = int64(Console.In.ReadLine())
let r2 = int64(Console.In.ReadLine())

let output = OutputGenerator.generate r1 r2   

printfn "%s" output
