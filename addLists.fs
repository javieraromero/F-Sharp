(* Write an F# function, plus (xs, ys) that creates a list with the sum of the
	numbers at each position in the lists. Assume the lists are the same length.

	sum ([1;7;3], [2;5;3]);;
		val it : int list = [3;12;6]
*)

(*
let rec plus (xs, ys) = function
	| ([], []) -> []
	| (xs, ys) -> (xs.Head + ys.Head) :: plus (xs.Tail, ys.Tail);;
*)

//NOTE: the upper function does not compile.

let rec plus xs ys =
	if List.isEmpty xs || List.isEmpty ys then []
	else (xs.Head + ys.Head) :: (plus xs.Tail ys.Tail);;

plus [1;7;3] [2;5;3];;