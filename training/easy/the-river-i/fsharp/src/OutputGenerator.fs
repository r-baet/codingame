module OutputGenerator

let private stateFunc (state: int64) =
    let s = string state
    let plus : int64 =
        s |> Seq.fold (fun acc x -> acc + int64 (string x)) 0
    Some(state,state+plus)

let private findSmallestCommonElement (seq1: seq<int64>) (seq2: seq<int64>) : string =
    if Seq.head seq1 < Seq.head seq2 then
        seq1
        |> Seq.find (fun el -> Seq.contains el (Seq.takeWhile (fun i -> i <= el) seq2))
        |> string
    else
        seq2
        |> Seq.find (fun el -> Seq.contains el (Seq.takeWhile (fun i -> i <= el) seq1))
        |> string  

let generate (river1: int64) (river2: int64) =
    let r1 = Seq.unfold stateFunc river1
    let r2 = Seq.unfold stateFunc river2
    findSmallestCommonElement r1 r2
