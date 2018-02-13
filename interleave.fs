let rec interleave xs ys =
	if List.isEmpty xs then ys
	elif List.isEmpty ys then xs
	else List.head xs :: List.head ys :: interleave (List.tail xs) (List.tail ys);;