module OutputGenerator

let generate (dimensions:string) (board:string[]) =
    let W = int((dimensions.Split[|' '|]).[0])
    let H = int((dimensions.Split[|' '|]).[1])
    let findTopLabels sequence =
        sequence
        |> Seq.head
        |> Seq.filter (fun c -> match c with | ' ' -> false | _ -> true)
    
    let rec findNextLeg height ix toRight =
        match board.[height].[ix] with
        | '-' ->
            findNextLeg height (if toRight then (ix+1) else (ix-1)) toRight
        | _ -> ix
    
    let rec traverseLine topLabel height ix =
        if height = H - 1 then
            new string [| topLabel ; (board.[height].[ix]) |]
        else
            let ix' = 
                match ix with
                | 0 -> match board.[height].[ix+1] with
                       | '-' -> findNextLeg height (ix+1) true
                       | _ -> ix
                | x when x = W - 1 -> match board.[height].[ix-1] with
                                      | '-' -> findNextLeg height (ix-1) false
                                      | _ -> ix
                | _ ->
                    if board.[height].[ix+1] = '-' then findNextLeg height (ix+1) true
                    elif board.[height].[ix-1] = '-' then findNextLeg height (ix-1) false
                    else ix
            traverseLine topLabel (height + 1) ix'
    
    let connectWithBottomLabel topLabel =
        board
        |> Seq.head
        |> Seq.findIndex (fun el -> el = topLabel)
        |> traverseLine topLabel 1

    board    
    |> findTopLabels
    |> Seq.map connectWithBottomLabel
    |> Seq.toArray
