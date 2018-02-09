let fib x = (0.4472135955 * (1.618033989 ** x) - 0.4472135955 * (-0.6180339887 ** x));;
let factorOf7 x = x % 7.0 = 0.0;;

let x = [(1.0)..(100.0)];;

List.map (fib) x;;
List.map (factorOf7) x;;