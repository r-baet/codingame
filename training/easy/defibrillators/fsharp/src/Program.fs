(* Auto-generated code below aims at helping you parse *)
(* the standard input according to the problem statement. *)
open System

let LON = Console.In.ReadLine()
let LAT = Console.In.ReadLine()
let N = int(Console.In.ReadLine())
let mutable defList = []
for i in 0 .. N - 1 do
    let DEFIB = Console.In.ReadLine()
    defList <- defList @ [DEFIB]
    ()

let defArray = defList |> List.toArray


(* Write an action using printfn *)
(* To debug: Console.Error.WriteLine("Debug message") *)
let answer = OutputGenerator.generate LON LAT N defArray

printfn "%s" answer
