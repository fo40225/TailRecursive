﻿// 請參閱 http://fsharp.org，進一步了解 F#
// 請參閱「F# 教學課程」專案，取得更多說明。
namespace FSFibonacci

module Program =
    let rec tailRecursiveAux a b n =
        if n < 1L then a
        else tailRecursiveAux b (a + b) (n - 1L)

    let Fibonacci (n:int64) =
        let f0 = 0I
        let f1 = 1I
        tailRecursiveAux f0 f1 n

    [<EntryPoint>]
    let main argv =
        ignore (System.Diagnostics.Debugger.Launch())
        let f = Fibonacci 1000L
        printfn "%A" f
        0 // 傳回整數的結束代碼