let rec gencut n xs =
	if n = 0 then []
	else (List.head xs) :: (gencut (n - 1) (List.tail xs));;

let cut xs =
	let lenOfLists = List.length xs / 2
	(gencut lenOfLists xs, List.rev (gencut lenOfLists (List.rev xs)));;