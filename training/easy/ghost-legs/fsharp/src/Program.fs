open System
open OutputGenerator

let token = (Console.In.ReadLine()).Split [|' '|]
let W = int(token.[0])
let H = int(token.[1])
// Commented out in favor of more F# logic
//for i in 0 .. H - 1 do
//    let line = Console.In.ReadLine()
//    ()
let diagram = Array.init H (fun _ -> Console.In.ReadLine())

let output = generate (String.Join(' ', token)) diagram
    
output
|> Array.iter (fun s -> printfn "%s" s)
