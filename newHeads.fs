let L1 = [1;7;2;6;9];;    //List 1

let L2 = [3;5;4;8;0];;    //List 2



let replaceHead x y =
  
	(List.head y :: List.tail x, List.head x :: List.tail y);;



let newHeads = replaceHead L1 L2;;

let newL1 = fst newHeads;;

let newL2 = snd newHeads;;