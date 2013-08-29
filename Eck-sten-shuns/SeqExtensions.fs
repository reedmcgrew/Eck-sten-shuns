module SeqExtensions

module Seq =
    let collecti operator operand =
        operand 
        |> Seq.mapi operator
        |> Seq.concat