let fizzbuzz x =
  
	if x % 3 = 0 && x % 5 = 0 then printfn "FizzBuzz"
  
	elif x % 3 = 0 then printfn "Fizz"
  
	elif x % 5 = 0 then printfn "Buzz"
  
	else printfn "%i" x
;;

let x = [1..100];;

List.map fizzbuzz x;;



let fizzNumbers = List.filter (fun x -> x % 3 = 0) x;;
let buzzNumbers = List.filter (fun x -> x % 5 = 0) x;;

let nonfizzbuzz = List.filter (fun x -> x % 3 <> 0 && x % 5 <> 0) x;;

let fizzbuzzNumbers = List.filter (fun x -> x % 3 = 0 && x % 5 = 0) x;;



printfn "The Fizz numbers are: %A" fizzNumbers;;

printfn "The Buzz numbers are: %A" buzzNumbers;;

printfn "The FizzBuzz numbers are: %A" fizzbuzzNumbers;;

printfn "The non FizzBuzz numbers are: %A" nonfizzbuzz;;