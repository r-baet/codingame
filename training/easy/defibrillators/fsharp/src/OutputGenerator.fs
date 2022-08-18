module OutputGenerator

open System

let generate longitude latitude nrOfDefibrillators (defibrillators : string[]) : string =
    let toRadians (s: string) : float =
        s.Replace (",", ".")
        |> float
        |> (fun f -> f * Math.PI / 180.0)
    let calc (s1: string) (s2: string) : string =
        let longA = toRadians longitude
        let latA = toRadians latitude
        let longB = toRadians s1
        let latB = toRadians s2
        let x = (longB - longA) * Math.Cos((latA + latB) / 2.0)
        let y = latB - latA
        Math.Sqrt(x * x + y * y) * 6371.0
        |> string
    defibrillators
    |> Array.map (fun d -> d.Split[|';'|])
    |> Array.map (fun s -> Array.append s [|calc s.[4] s.[5]|])
    |> Array.sortBy (fun s -> float s.[6])
    |> Array.head
    |> Seq.item 1
