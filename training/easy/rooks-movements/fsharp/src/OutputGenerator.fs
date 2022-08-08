module OutputGenerator

type ChessPiece = {
    Color: int
    Position: string
}

let generate rookPosition numberOfPieces (positions:string[]) =
    let rook = { Color = 0 ; Position = rookPosition }
    let otherPieces = 
        positions
        |> Array.map (fun i -> i.Split ' ')
        |> Array.map (fun i -> { Color = int i.[0] ; Position = i.[1] })
    
    let mutable answers : string list = []

    let rec move (newPositionFunc: string -> string) (checkPosition: int) (compareChar : char) (pos : string) =
        match pos.[checkPosition] with
        | x when x = compareChar -> ()
        | _ -> 
            let nextPosition = newPositionFunc pos
            match (Array.tryFind (fun el -> el.Position = nextPosition) otherPieces) with
            | None -> 
                answers <- ("R" + rook.Position + "-" + nextPosition) :: answers
                move newPositionFunc checkPosition compareChar nextPosition
            | Some x -> if x.Color = rook.Color then () else answers <- ("R" + rook.Position + "x" + x.Position) :: answers

    rook.Position |> move (fun s -> new string [| char((int s.[0])-1) ; s.[1] |]) 0 'a'
    rook.Position |> move (fun s -> new string [| char((int s.[0])+1) ; s.[1] |]) 0 'h'
    rook.Position |> move (fun s -> new string [| s.[0] ; char((int s.[1])+1) |]) 1 '8'
    rook.Position |> move (fun s -> new string [| s.[0] ; char((int s.[1])-1) |]) 1 '1'
    answers |> List.sort |> List.toArray
