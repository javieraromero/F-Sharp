let areaWithIntegers = 
	fun x ->
		fun y ->
			 x * y;;

let x = 9;;
let y = 25;;
printfn "Area of a rectangle that is %i units long and %i units wide is %i" x y (areaWithIntegers x y);;

let areaWithFloats =
	fun x ->
		fun y ->
			(x * y) / 1.0;;

let x = 11.0;;
let y = 27.3;;
printfn "Area of a rectangle that is %f units long and %f units wide is %f" x y (areasWithFloats x y);;