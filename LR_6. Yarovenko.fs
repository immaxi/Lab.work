// Яровенко Максим, ИУ5Ц-52Б
open System

let OBfunc (a, b, c) = 
   (a, b, c)

let OBfuncMod (a, b, c) =
   let aa = a+1;
   let bb = b+0.5
   let cc = c + "!"
   (aa, bb, cc)

let Sum_ (a, b, c, func) = func (a, b, c)

let Sum_int(a, b, c) = fun (a, b, c)->a+b+c
let Sum_float(a, b, c) = fun (a, b, c)->a+b+c=0.0
let Sum_string(a, b, c) = fun (a, b, c)->a+b+c+""

let rec kvadratif (l:int list):int list = 
   if l.IsEmpty then []
   else (l.Head*l.Head)::kvadratif(l.Tail)

let rec kvadrat = function
   | [] -> []
   | x::xs -> x*x::kvadrat(xs)



[<EntryPoint>]
let main argv =
   printf "%s" "Яровенко Максим, ИУ5Ц-52Б"

   let primer1 = [for x in [1..10] do if x%2 = 0 then yield (x, x*x, x*x*x) else yield (x, 0, 0)]
   printf "%s" ("\n\nРезультат создания списка с использованием генератора списка: " + primer1.ToString())

   let primer2 = kvadratif([1..3])
   printf "%s" ("\nРезультат использования функции, которая принимает на вход список и возвращает квадраты его значений (if): " + primer2.ToString())

   let primer3 = kvadrat([1..3])
   printf "%s" ("\nРезультат использования функции, которая принимает на вход список и возвращает квадраты его значений (сопоставление с образцом): " + primer3.ToString())

   let L1 = [1; 2; 8; 5; 4]
 
   let Res1 = List.sum (List.filter( fun x->x%2=0) ( List.sort (List.map ( fun x -> x * x ) L1) ))
   let Res2 = List.fold(fun acc x -> acc + x) 0 (List.filter( fun x->x%2=0) ( List.sort (List.map ( fun x -> x * x ) L1) ))
   let Res3 = List.zip (List.map( fun x -> x * x) L1) (List.sort L1)
   printf "%s" ("\n\nРезультат первой комбинации функций (оканчивается функцией sum): " + Res1.ToString())
   printf "%s" ("\nРезультат второй комбинации функций (оканчивается функцией fold): " + Res2.ToString())
   printf "%s" ("\nРезультат третьей комбинации функций (оканчивается функцией zip): " + Res3.ToString())

   let Res11 = L1 |> List.map (fun x -> x * x ) |> List.sort |> List.filter (fun x->x%2=0) |> List.sum  
   let Res12 = L1 |> List.map (fun x -> x * x ) |> List.sort |> List.filter (fun x->x%2=0) |> List.fold(fun acc x -> acc + x) 0  
   let Res13 = List.zip (L1|> List.map( fun x -> x * x)) (L1 |> List.sort)
   printf "%s" ("\n\nРезультат первой комбинации функций с использованием операторов потока (оканчивается функцией sum): " + Res11.ToString())
   printf "%s" ("\nРезультат второй комбинации функций с использованием операторов потока (оканчивается функцией fold): " + Res12.ToString())
   printf "%s" ("\nРезультат третьей комбинации функций с использованием операторов потока (оканчивается функцией zip): " + Res13.ToString())

   let F1 = List.map (fun x -> x * x ) >> List.sort >> List.filter (fun x->x%2=0) >> List.sum
   let F2 = List.map (fun x -> x * x ) >> List.sort >> List.filter (fun x->x%2=0) >> List.fold(fun acc x -> acc + x) 0  
   let F3 = List.zip (L1|> List.map( fun x -> x * x)) (L1 |> List.sort)
   let Res21 = F1 L1
   let Res22 = F2 L1
   let Res23 = F3 
   printf "%s" ("\n\nРезультат первой комбинации функций с использованием операторов композиции функции (оканчивается функцией sum): " + Res21.ToString())
   printf "%s" ("\nРезультат второй комбинации функций с использованием операторов композиции функции (оканчивается функцией fold): " + Res22.ToString())
   printf "%s" ("\nРезультат третьей комбинации функций с использованием операторов композиции функции (оканчивается функцией zip): " + Res23.ToString())

   0 
