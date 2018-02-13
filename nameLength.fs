let nameLength name =
	match String.length name with
  
	| 0 -> "No name entered"
  
	| 2 | 3 -> "Short name"
  
	| 4 | 5 | 6 | 7 -> "Normal name"
  
	| _ -> "Long name";;



let myName = "Javier";;

let shortName = "Dee";;

let mediumName = "Charlie";;

let longName = "Elizabeth";;

let anotherLongName = "Abdul Jabbar";;



nameLength myName;;

nameLength shortName;;

nameLength mediumName;;

nameLength longName;;

nameLength anotherLongName;;