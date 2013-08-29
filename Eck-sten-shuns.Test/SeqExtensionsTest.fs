namespace Eck_sten_shuns.Test

open NUnit.Framework
open FsUnit
open SeqExtensions

[<TestFixture>] 
type ``collecti test`` () =

    [<Test>] member x.
        ``It flattens results`` () =
            seq { for i in 1..3 do yield seq {1..2} } 
            |> Seq.collecti (fun idx elem -> elem) 
            |> Seq.toList 
            |> should equal [1;2;1;2;1;2]