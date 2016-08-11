﻿module EulerF.Problem34

let Factorial n = 
    if n <= 1 then 1
    else [ 1..n ] |> List.reduce (*)

let rec Digits n = 
    seq { 
        yield n % 10
        if n / 10 <> 0 then yield! Digits(n / 10)
    }

let sumOfFactorialOfDigit n = 
    Digits n
    |> Seq.map Factorial
    |> Seq.sum

let isCurious n = n = sumOfFactorialOfDigit n

let Solution = 
    [ 3..409114 ] // upper limit is sumOfFactorialOfDigit 9876543210
    |> List.filter isCurious
    |> List.sum
