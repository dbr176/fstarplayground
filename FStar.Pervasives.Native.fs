#light "off"
module FStar.Pervasives.Native
open Prims
open FStar.Pervasives
type 'Aa option =
| None
| Some of 'Aa


let uu___is_None = (fun ( projectee  :  'Aa option ) -> (match (projectee) with
| None -> begin
true
end
| uu____30 -> begin
false
end))


let uu___is_Some = (fun ( projectee  :  'Aa option ) -> (match (projectee) with
| Some (v) -> begin
true
end
| uu____52 -> begin
false
end))


let __proj__Some__item__v = (fun ( projectee  :  'Aa option ) -> (match (projectee) with
| Some (v) -> begin
v
end))

type ('a, 'b) tuple2 =
| Mktuple2 of 'a * 'b


let uu___is_Mktuple2 = (fun ( projectee  :  ('a * 'b) ) -> true)


let __proj__Mktuple2__item___1 = (fun ( projectee  :  ('a * 'b) ) -> (match (projectee) with
| (_1, _2) -> begin
_1
end))


let __proj__Mktuple2__item___2 = (fun ( projectee  :  ('a * 'b) ) -> (match (projectee) with
| (_1, _2) -> begin
_2
end))


let fst = (fun ( x  :  ('a * 'b) ) -> (__proj__Mktuple2__item___1 x))


let snd = (fun ( x  :  ('a * 'b) ) -> (__proj__Mktuple2__item___2 x))

type ('a, 'b, 'c) tuple3 =
| Mktuple3 of 'a * 'b * 'c


let uu___is_Mktuple3 = (fun ( projectee  :  ('a * 'b * 'c) ) -> true)


let __proj__Mktuple3__item___1 = (fun ( projectee  :  ('a * 'b * 'c) ) -> (match (projectee) with
| (_1, _2, _3) -> begin
_1
end))


let __proj__Mktuple3__item___2 = (fun ( projectee  :  ('a * 'b * 'c) ) -> (match (projectee) with
| (_1, _2, _3) -> begin
_2
end))


let __proj__Mktuple3__item___3 = (fun ( projectee  :  ('a * 'b * 'c) ) -> (match (projectee) with
| (_1, _2, _3) -> begin
_3
end))

type ('a, 'b, 'c, 'd) tuple4 =
| Mktuple4 of 'a * 'b * 'c * 'd


let uu___is_Mktuple4 = (fun ( projectee  :  ('a * 'b * 'c * 'd) ) -> true)


let __proj__Mktuple4__item___1 = (fun ( projectee  :  ('a * 'b * 'c * 'd) ) -> (match (projectee) with
| (_1, _2, _3, _4) -> begin
_1
end))


let __proj__Mktuple4__item___2 = (fun ( projectee  :  ('a * 'b * 'c * 'd) ) -> (match (projectee) with
| (_1, _2, _3, _4) -> begin
_2
end))


let __proj__Mktuple4__item___3 = (fun ( projectee  :  ('a * 'b * 'c * 'd) ) -> (match (projectee) with
| (_1, _2, _3, _4) -> begin
_3
end))


let __proj__Mktuple4__item___4 = (fun ( projectee  :  ('a * 'b * 'c * 'd) ) -> (match (projectee) with
| (_1, _2, _3, _4) -> begin
_4
end))

type ('a, 'b, 'c, 'd, 'e) tuple5 =
| Mktuple5 of 'a * 'b * 'c * 'd * 'e


let uu___is_Mktuple5 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> true)


let __proj__Mktuple5__item___1 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5) -> begin
_1
end))


let __proj__Mktuple5__item___2 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5) -> begin
_2
end))


let __proj__Mktuple5__item___3 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5) -> begin
_3
end))


let __proj__Mktuple5__item___4 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5) -> begin
_4
end))


let __proj__Mktuple5__item___5 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5) -> begin
_5
end))

type ('a, 'b, 'c, 'd, 'e, 'f) tuple6 =
| Mktuple6 of 'a * 'b * 'c * 'd * 'e * 'f


let uu___is_Mktuple6 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> true)


let __proj__Mktuple6__item___1 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_1
end))


let __proj__Mktuple6__item___2 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_2
end))


let __proj__Mktuple6__item___3 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_3
end))


let __proj__Mktuple6__item___4 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_4
end))


let __proj__Mktuple6__item___5 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_5
end))


let __proj__Mktuple6__item___6 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6) -> begin
_6
end))

type ('a, 'b, 'c, 'd, 'e, 'f, 'g) tuple7 =
| Mktuple7 of 'a * 'b * 'c * 'd * 'e * 'f * 'g


let uu___is_Mktuple7 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> true)


let __proj__Mktuple7__item___1 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_1
end))


let __proj__Mktuple7__item___2 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_2
end))


let __proj__Mktuple7__item___3 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_3
end))


let __proj__Mktuple7__item___4 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_4
end))


let __proj__Mktuple7__item___5 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_5
end))


let __proj__Mktuple7__item___6 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_6
end))


let __proj__Mktuple7__item___7 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7) -> begin
_7
end))

type ('a, 'b, 'c, 'd, 'e, 'f, 'g, 'h) tuple8 =
| Mktuple8 of 'a * 'b * 'c * 'd * 'e * 'f * 'g * 'h


let uu___is_Mktuple8 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> true)


let __proj__Mktuple8__item___1 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_1
end))


let __proj__Mktuple8__item___2 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_2
end))


let __proj__Mktuple8__item___3 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_3
end))


let __proj__Mktuple8__item___4 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_4
end))


let __proj__Mktuple8__item___5 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_5
end))


let __proj__Mktuple8__item___6 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_6
end))


let __proj__Mktuple8__item___7 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_7
end))


let __proj__Mktuple8__item___8 = (fun ( projectee  :  ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h) ) -> (match (projectee) with
| (_1, _2, _3, _4, _5, _6, _7, _8) -> begin
_8
end))


let normalize_term = (fun ( x  :  'Aa ) -> x)


type 'Aa normalize =
'Aa

type norm_step =
| Simpl
| Weak
| HNF
| Primops
| Delta
| Zeta
| Iota
| UnfoldOnly of Prims.string Prims.list
| UnfoldFully of Prims.string Prims.list
| UnfoldAttr of unit * obj


let uu___is_Simpl : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Simpl -> begin
true
end
| uu____3131 -> begin
false
end))


let uu___is_Weak : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Weak -> begin
true
end
| uu____3139 -> begin
false
end))


let uu___is_HNF : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| HNF -> begin
true
end
| uu____3147 -> begin
false
end))


let uu___is_Primops : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Primops -> begin
true
end
| uu____3155 -> begin
false
end))


let uu___is_Delta : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Delta -> begin
true
end
| uu____3163 -> begin
false
end))


let uu___is_Zeta : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Zeta -> begin
true
end
| uu____3171 -> begin
false
end))


let uu___is_Iota : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| Iota -> begin
true
end
| uu____3179 -> begin
false
end))


let uu___is_UnfoldOnly : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnly (_0) -> begin
true
end
| uu____3191 -> begin
false
end))


let __proj__UnfoldOnly__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldOnly (_0) -> begin
_0
end))


let uu___is_UnfoldFully : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldFully (_0) -> begin
true
end
| uu____3219 -> begin
false
end))


let __proj__UnfoldFully__item___0 : norm_step  ->  Prims.string Prims.list = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldFully (_0) -> begin
_0
end))


let uu___is_UnfoldAttr : norm_step  ->  Prims.bool = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldAttr (t, a) -> begin
true
end
| uu____3247 -> begin
false
end))


type 'Aprojectee __proj__UnfoldAttr__item__t =
obj


let __proj__UnfoldAttr__item__a : norm_step  ->  obj = (fun ( projectee  :  norm_step ) -> (match (projectee) with
| UnfoldAttr (t, a) -> begin
a
end))


let simplify : norm_step = Simpl


let weak : norm_step = Weak


let hnf : norm_step = HNF


let primops : norm_step = Primops


let delta : norm_step = Delta


let zeta : norm_step = Zeta


let iota : norm_step = Iota


let delta_only : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldOnly (s))


let delta_fully : Prims.string Prims.list  ->  norm_step = (fun ( s  :  Prims.string Prims.list ) -> UnfoldFully (s))


let delta_attr = (fun ( a  :  'At ) -> UnfoldAttr ((), (Prims.unsafe_coerce a)))


let norm : norm_step Prims.list  ->  unit  ->  obj  ->  obj = (fun ( s  :  norm_step Prims.list ) ( a  :  unit ) ( x  :  obj ) -> x)














let singleton = (fun ( x  :  'Aa ) -> x)


let with_type = (fun ( e  :  'At ) -> e)




