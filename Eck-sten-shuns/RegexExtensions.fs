module RegexExtensions
open System.Text.RegularExpressions

type MatchCollection with
    member this.ToSeq () =
        let enumerator = this.GetEnumerator()
        seq {
            while enumerator.MoveNext() do yield enumerator.Current :?> Match
        }