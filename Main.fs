#light "off"
module Main
open Prims
open FStar.Pervasives

let even : Prims.int  ->  Prims.bool = (fun ( x  :  Prims.int ) -> (Prims.op_Equality (x mod (Prims.parse_int "2")) (Prims.parse_int "0")))


let odd : Prims.int  ->  Prims.bool = (fun ( x  :  Prims.int ) -> (Prims.op_disEquality (x mod (Prims.parse_int "2")) (Prims.parse_int "0")))


type nat =
Prims.int


type neg =
Prims.int


type _even =
Prims.int


type _odd =
Prims.int


let add2 : Prims.int  ->  Prims.int = (fun ( x  :  Prims.int ) -> (x + (Prims.parse_int "2")))





let mul2 : Prims.int  ->  _even = (fun ( x  :  Prims.int ) -> (x * (Prims.parse_int "2")))


let rec fib : nat  ->  nat = (fun ( n  :  nat ) -> (match (((Prims.op_Equality n (Prims.parse_int "1")) || (Prims.op_Equality n (Prims.parse_int "2")))) with
| true -> begin
(Prims.parse_int "1")
end
| uu____57 -> begin
((fib (n - (Prims.parse_int "1"))) + (fib (n - (Prims.parse_int "2"))))
end))


let rec isSorted : Prims.int Prims.list  ->  Prims.bool = (fun ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
true
end
| (x)::[] -> begin
true
end
| (h1)::(h2)::t -> begin
((h1 <= h2) && (isSorted ((h2)::t)))
end))


type sortedList =
Prims.int Prims.list


let sl : sortedList = ((Prims.parse_int "1"))::((Prims.parse_int "2"))::((Prims.parse_int "3"))::((Prims.parse_int "4"))::((Prims.parse_int "5"))::((Prims.parse_int "6"))::[]




