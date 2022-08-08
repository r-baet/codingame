open System
open OutputGenerator

let rookPosition = Console.In.ReadLine()
let nbPieces = int(Console.In.ReadLine())

// Commented out for more specific F# logic
//for i in 0 .. nbPieces - 1 do
//    let token = (Console.In.ReadLine()).Split [|' '|]
//    let colour = int(token.[0])
//    let onePiece = token.[1]
//    ()

let otherPieces = Array.init nbPieces (fun ix -> Console.In.ReadLine())

let output = generate rookPosition nbPieces otherPieces

output |> Array.iter (fun ans -> printfn "%s" ans)
