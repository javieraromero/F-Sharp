let rec fac = function

    | 1 -> 1

    | x -> x * fac (x - 1);;



let rec fib n =

    if n = 0 then 0

    elif n = 1 then 1

    else fib(n - 1) + fib(n - 2);;



let input = 7;;


printfn "%i factorial is %i" input (fac input);;

printfn "The %ith fibonacci number is %i" input (fib input);;