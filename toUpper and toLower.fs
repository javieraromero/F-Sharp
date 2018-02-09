let msgList = ['H'; 'e'; 'l'; 'l'; 'o'; ','; ' '; 'w'; 'o'; 'r'; 'l'; 'd'; '!'];;

let msgToUpper = System.String.Concat(List.map (fun x -> System.Char.ToUpper x) msgList);;

let msgToLower = System.String.Concat(List.map (fun x -> System.Char.ToLower x) msgList);;


let msgString = System.String.Concat(msgList);;



printfn "%A" msgString;;
printfn "%A" msgToUpper;;

printfn "%A" msgToLower;;