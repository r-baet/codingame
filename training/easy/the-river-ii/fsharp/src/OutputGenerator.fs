module OutputGenerator

let generate meeting =    
    let rec goBackwards nr : string =
        let s = string nr
        let acc = nr + (Seq.fold (fun acc x -> acc + int (string x)) 0 s)
        match acc with
        | x when x = meeting -> "YES"
        | x when x > meeting -> goBackwards (nr-1)
        | _ ->
            if nr + 10 * s.Length > meeting then goBackwards (nr-1) else "NO"
    goBackwards (meeting-1)
