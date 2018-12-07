module Main

let even x = x % 2 = 0
let odd x = x % 2 <> 0

type nat = x:int{x > 0}
type neg = x:int{x < 0}

type _even = x:int{even x}
type _odd = x:int{odd x}

val add2: int -> Tot int
let add2 x = x + 2

let _ = assert(forall x. add2 x > x)

open FStar.Mul

val mul2: int -> Tot _even
let mul2 x = x * 2

val fib : nat -> Tot nat
let rec fib n =
    if n = 1 || n = 2
    then 1
    else fib (n - 1) + fib (n - 2)
    
val isSorted : l: list int -> Tot bool
let rec isSorted l =
    match l with
    | [] -> true
    | [x] -> true
    | h1::h2::t -> h1 <= h2 && isSorted (h2::t)
    
type sortedList = l:list int {isSorted l}

val sl : sortedList
let sl = [1;2;3;4;5;6]    
    