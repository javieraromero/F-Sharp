let rec gcf x y =
	if y = 0 then x
	else gcf y (x % y);;

let lcm x y = x * (y / gcf x y);;

let rec = Myfile.rec;;

let (.+) (a, b) (c, d) =
	let LCM = lcm b d
	let div1 = LCM / b
	let div2 = LCM / d
	let newA = a * div1
	let newC = c * div2
	let GCF = gcf newA newC
	(((newA + newC) / GCF), (LCM / GCF));;

let (.*) (a, b) (c, d) = 
	let GCF = gcf (a * c) (b * d)
	(((a * c) / GCF), ((b * d) / GCF));;
