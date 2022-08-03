open System

let r1 = int(Console.In.ReadLine())

let output = OutputGenerator.generate r1

printfn "%s" output
