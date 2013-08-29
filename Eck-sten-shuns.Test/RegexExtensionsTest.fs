namespace Eck_sten_shuns.Test

open NUnit.Framework
open FsUnit
open RegexExtensions
open System.Text.RegularExpressions

[<TestFixture>]
type ``ToSeq extension test`` () =

    [<Test>] member x.
        ``It produces a list of matches`` () =
            Regex.Matches("a b b a a a b b a a", "b b").ToSeq()
            |> Seq.toList
            |> List.length
            |> should equal 2