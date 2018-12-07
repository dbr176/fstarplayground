#light "off"
module FStar.Pervasives
open Prims

let id = (fun ( x  :  'Aa ) -> x)


type 'Aheap st_pre_h =
unit


type ('Aheap, 'Aa, 'Apre) st_post_h' =
unit


type ('Aheap, 'Aa) st_post_h =
unit


type ('Aheap, 'Aa) st_wp_h =
unit


type ('Aheap, 'Aa, 'Ax, 'Ap, 'Auu___7_79) st_return =
'Ap


type ('Aheap, 'Ar1, 'Aa, 'Ab, 'Awp1, 'Awp2, 'Ap, 'Ah0) st_bind_wp =
'Awp1


type ('Aheap, 'Aa, 'Ap, 'Awp_then, 'Awp_else, 'Apost, 'Ah0) st_if_then_else =
unit


type ('Aheap, 'Aa, 'Awp, 'Apost, 'Ah0) st_ite_wp =
unit


type ('Aheap, 'Aa, 'Awp1, 'Awp2) st_stronger =
unit


type ('Aheap, 'Aa, 'Ab, 'Awp, 'Ap, 'Ah) st_close_wp =
unit


type ('Aheap, 'Aa, 'Ap, 'Awp, 'Aq, 'Ah) st_assert_p =
unit


type ('Aheap, 'Aa, 'Ap, 'Awp, 'Aq, 'Ah) st_assume_p =
unit


type ('Aheap, 'Aa, 'Ap, 'Ah) st_null_wp =
unit


type ('Aheap, 'Aa, 'Awp) st_trivial =
unit

type 'Aa result =
| V of 'Aa
| E of Prims.exn
| Err of Prims.string


let uu___is_V = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| V (v) -> begin
true
end
| uu____413 -> begin
false
end))


let __proj__V__item__v = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| V (v) -> begin
v
end))


let uu___is_E = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| E (e) -> begin
true
end
| uu____455 -> begin
false
end))


let __proj__E__item__e = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| E (e) -> begin
e
end))


let uu___is_Err = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| Err (msg) -> begin
true
end
| uu____497 -> begin
false
end))


let __proj__Err__item__msg = (fun ( projectee  :  'Aa result ) -> (match (projectee) with
| Err (msg) -> begin
msg
end))


type ex_pre =
unit


type ('Aa, 'Apre) ex_post' =
unit


type 'Aa ex_post =
unit


type 'Aa ex_wp =
unit


type ('Aa, 'Ax, 'Ap) ex_return =
'Ap


type ('Ar1, 'Aa, 'Ab, 'Awp1, 'Awp2, 'Ap) ex_bind_wp =
unit


type ('Aa, 'Awp, 'Apost) ex_ite_wp =
unit


type ('Aa, 'Ap, 'Awp_then, 'Awp_else, 'Apost) ex_if_then_else =
unit


type ('Aa, 'Awp1, 'Awp2) ex_stronger =
unit


type ('Aa, 'Ab, 'Awp, 'Ap) ex_close_wp =
unit


type ('Aa, 'Aq, 'Awp, 'Ap) ex_assert_p =
unit


type ('Aa, 'Aq, 'Awp, 'Ap) ex_assume_p =
unit


type ('Aa, 'Ap) ex_null_wp =
unit


type ('Aa, 'Awp) ex_trivial =
'Awp


type ('Aa, 'Awp, 'Ap) lift_div_exn =
'Awp


type 'Ah all_pre_h =
unit


type ('Ah, 'Aa, 'Apre) all_post_h' =
unit


type ('Ah, 'Aa) all_post_h =
unit


type ('Ah, 'Aa) all_wp_h =
unit


type ('Aheap, 'Aa, 'Awp, 'Apost, 'Ah0) all_ite_wp =
unit


type ('Aheap, 'Aa, 'Ax, 'Ap, 'Auu___10_867) all_return =
'Ap


type ('Aheap, 'Ar1, 'Aa, 'Ab, 'Awp1, 'Awp2, 'Ap, 'Ah0) all_bind_wp =
'Awp1


type ('Aheap, 'Aa, 'Ap, 'Awp_then, 'Awp_else, 'Apost, 'Ah0) all_if_then_else =
unit


type ('Aheap, 'Aa, 'Awp1, 'Awp2) all_stronger =
unit


type ('Aheap, 'Aa, 'Ab, 'Awp, 'Ap, 'Ah) all_close_wp =
unit


type ('Aheap, 'Aa, 'Ap, 'Awp, 'Aq, 'Ah) all_assert_p =
unit


type ('Aheap, 'Aa, 'Ap, 'Awp, 'Aq, 'Ah) all_assume_p =
unit


type ('Aheap, 'Aa, 'Ap, 'Ah0) all_null_wp =
unit


type ('Aheap, 'Aa, 'Awp) all_trivial =
unit


type 'Aa inversion =
unit







type ('a, 'b) either =
| Inl of 'a
| Inr of 'b


let uu___is_Inl = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inl (v) -> begin
true
end
| uu____1190 -> begin
false
end))


let __proj__Inl__item__v = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inl (v) -> begin
v
end))


let uu___is_Inr = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inr (v) -> begin
true
end
| uu____1250 -> begin
false
end))


let __proj__Inr__item__v = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inr (v) -> begin
v
end))


let dfst = (fun ( t  :  ('Aa, 'Ab) Prims.dtuple2 ) -> (Prims.__proj__Mkdtuple2__item___1 t))


let dsnd = (fun ( t  :  ('Aa, 'Ab) Prims.dtuple2 ) -> (Prims.__proj__Mkdtuple2__item___2 t))

type ('Aa, 'Ab, 'Ac) dtuple3 =
| Mkdtuple3 of 'Aa * 'Ab * 'Ac


let uu___is_Mkdtuple3 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac) dtuple3 ) -> true)


let __proj__Mkdtuple3__item___1 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_1
end))


let __proj__Mkdtuple3__item___2 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_2
end))


let __proj__Mkdtuple3__item___3 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_3
end))

type ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 =
| Mkdtuple4 of 'Aa * 'Ab * 'Ac * 'Ad


let uu___is_Mkdtuple4 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 ) -> true)


let __proj__Mkdtuple4__item___1 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_1
end))


let __proj__Mkdtuple4__item___2 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_2
end))


let __proj__Mkdtuple4__item___3 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_3
end))


let __proj__Mkdtuple4__item___4 = (fun ( projectee  :  ('Aa, 'Ab, 'Ac, 'Ad) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_4
end))





let rec false_elim = (fun ( u  :  unit ) -> (false_elim ()))

type __internal_ocaml_attributes =
| PpxDerivingShow
| PpxDerivingShowConstant of Prims.string
| PpxDerivingYoJson
| CInline
| Substitute
| Gc
| Comment of Prims.string
| CPrologue of Prims.string
| CEpilogue of Prims.string
| CConst of Prims.string


let uu___is_PpxDerivingShow : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| PpxDerivingShow -> begin
true
end
| uu____1997 -> begin
false
end))


let uu___is_PpxDerivingShowConstant : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| PpxDerivingShowConstant (_0) -> begin
true
end
| uu____2007 -> begin
false
end))


let __proj__PpxDerivingShowConstant__item___0 : __internal_ocaml_attributes  ->  Prims.string = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| PpxDerivingShowConstant (_0) -> begin
_0
end))


let uu___is_PpxDerivingYoJson : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| PpxDerivingYoJson -> begin
true
end
| uu____2025 -> begin
false
end))


let uu___is_CInline : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CInline -> begin
true
end
| uu____2033 -> begin
false
end))


let uu___is_Substitute : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| Substitute -> begin
true
end
| uu____2041 -> begin
false
end))


let uu___is_Gc : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| Gc -> begin
true
end
| uu____2049 -> begin
false
end))


let uu___is_Comment : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| Comment (_0) -> begin
true
end
| uu____2059 -> begin
false
end))


let __proj__Comment__item___0 : __internal_ocaml_attributes  ->  Prims.string = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| Comment (_0) -> begin
_0
end))


let uu___is_CPrologue : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CPrologue (_0) -> begin
true
end
| uu____2079 -> begin
false
end))


let __proj__CPrologue__item___0 : __internal_ocaml_attributes  ->  Prims.string = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CPrologue (_0) -> begin
_0
end))


let uu___is_CEpilogue : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CEpilogue (_0) -> begin
true
end
| uu____2099 -> begin
false
end))


let __proj__CEpilogue__item___0 : __internal_ocaml_attributes  ->  Prims.string = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CEpilogue (_0) -> begin
_0
end))


let uu___is_CConst : __internal_ocaml_attributes  ->  Prims.bool = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CConst (_0) -> begin
true
end
| uu____2119 -> begin
false
end))


let __proj__CConst__item___0 : __internal_ocaml_attributes  ->  Prims.string = (fun ( projectee  :  __internal_ocaml_attributes ) -> (match (projectee) with
| CConst (_0) -> begin
_0
end))




























