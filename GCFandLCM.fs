//Euclid's algorithm for the GCF

let rec gcf x y =
	if y = 0 then x
	else gcf y (x % y);;

let lcm x y = x * (y / gcf x y);;