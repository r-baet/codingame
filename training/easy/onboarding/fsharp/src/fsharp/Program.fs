open System
open OutputGenerator

(* game loop *)
while true do
    let enemy1 = Console.In.ReadLine() (* name of enemy 1 *)
    let dist1 = int(Console.In.ReadLine()) (* distance to enemy 1 *)
    let enemy2 = Console.In.ReadLine() (* name of enemy 2 *)
    let dist2 = int(Console.In.ReadLine()) (* distance to enemy 2 *)
    
    (* Write an action using printfn *)
    
    (* Enter the code here *)
    let output = OutputGenerator.generate enemy1 dist1 enemy2 dist2

    printfn "%s" output
    
    ()
