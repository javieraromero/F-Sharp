let rec interleave xs ys =
	if List.isEmpty xs then ys
	elif List.isEmpty ys then xs
	else List.head xs :: List.head ys :: interleave (List.tail xs) (List.tail ys);;

let rec gencut n xs =
	if n = 0 then []
	else (List.head xs) :: (gencut (n - 1) (List.tail xs));;

let cut xs =
	let lenOfLists = List.length xs / 2
	(gencut lenOfLists xs, List.rev (gencut lenOfLists (List.rev xs)));;

let shuffle xs =
	let (x, y) = cut xs
	interleave x y;;