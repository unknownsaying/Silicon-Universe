class X1Y1Z1T1{}{
function X1() {
    for (let i = 0; i <= 3; ++i)
        for(let j = 0; i <= 3; ++j)
            for(let k = 0; k <= 3; ++k)
        continue
}
function Y1(){
    for(let l = 0;-3 <= l && l <= 3; ++l || l--)
       for(let m = 0;-3 <= m && m <= 3 ;++m || m--)
          for(let n = 0 ;-3 <= n && n <= 3;++n || n--)
        break
}
function Z1(){
    for(let o = 0;o >= -3;o--)
        for(let p = 0; p >= -3;p--)
            for(let q = 0; q >= -3; q--)
        continue
}
void function T1(){
    void ('X1*Y1')
     {Z1}
    void ('X1*Z1')
     {Y1}
    void ('Y1*Z1')
     {X1}
}
}

class X2Y2Z2T2{}{
function X2(){
    for (let i = 0; i <= 6; ++i)
        for (let j = 0; j <= 6; ++j)
            for (let k = 0; k <= 6; ++k)
        continue
}
function Y2(){
    for (let l = 0; l <= -6 || l >= 6; l++ || --l)
        for (let m = 0; m <= -6 && m >= 6; m++ || --m)
            for (let n = 0; n <= -6 && n >= 6; n++ || --n)
        break
}
function Z2(){
    for (let o = 0; o >= -6; o--)
        for (let p = 0; p >= -6; p--)
            for (let q = 0; q >= -6; q--)
        continue
}
void function T2(){
    void ('X2*Y2')
     {Z2}
    void ('X2*Y2')
     {Y2}
    void ('Y2*Z2')
     {X2}
}
}

class X3Y3Z3T3{}{
function X3() {
    for (let i = 0; i <= 9; i++)
        for (let j = 0; j <= 9; j++)
            for (let k = 0; k <= 9; k++)
        continue
}
function Y3(){
    for (let l = 0;l <= -9 && l >= 9; l++ || l--)
        for(let m = 0;m <= -9 && m >= 9;m++ || m--)
            for(let n = 0;n <= -9 && n >= 9;n++ || n--)
        break
}
function Z3() {
    for (let o = 0; o >= -9; o--)
        for (let p = 0; p >= -9; p--)
            for (let q = 0; q >= -9; q--)
        continue
}
void function T3(){
    void ('X3*Y3')
     {Z3}
    void ('X3*Z3')
     {Y3}
    void ('Y3*Z3')
     {X3}
}
}

class X4Y4Z4T4{}{
function X4() {
    for (let I = 0; I <= 2; I++)
        for(let J = 0; J <= 2; J++)
            for(let K = 0; K <= 2; K++)
        break
}
function Y4(){
    for(let L = 0;-2 <= L &&  L <= 2; L++ || --L)
        for(let M = 0;-2 <= M && M <= 2;M++ || --M)
            for(let N = 0;-2 <= N && N <= 2; N++ || --N) 
        continue       
}
function Z4(){
    for (let O = 0; O >= -2; --O)
        for (let P = 0; P >= -2; --P)
            for (let Q = 0; Q >= -2; --Q)
        break
}
void function T1(){
    void ('X4*Y4')
     {Z4}
    void ('X4*Z4')
     {Y4}
    void ('Y4*Z4')
     {X4}
}
}

class X5Y5Z5T5{}{
function X5(){
    for (let I = 0; I <= 4; ++I)
       for (let J = 0; J <= 4; ++J)
          for (let K = 0; K <= 4; ++K)
        break
}
function Y5() {
    for (let L = 0; L <= -4 && L <= 4; ++L || L--)
        for (let M = 0; M <= -4 && M <= 4; ++M || M--)
            for (let N = 0; N <= -4 && N <= 4; ++N || N--)
        continue
}
function Z5(){
    for (let O = 0; O >= -4; O--)
       for (let P = 0; P >= -4; P--)
          for (let Q = 0; Q >= -4; Q--)
        break
}

void function T5(){
    void ('X5*Y5')
     {Z5}
    void ('X5*Z5')
     {Y5}
    void ('Y5*Z5')
     {X5}
}
}

class X6Y6Z6T6{}{
function X6(){
    for (let I = 0; I <= 8; I++)
        for(let J = 0; J <= 8; J++)
            for(let K = 0; K <= 8; K++)
        break
}
function Y6(){ 
    for(let L = 0;-8 <= L && L <= 8; L++ || L--)
        for(let M = 0;-8 <= M && M <= 8;M++ || M--)
            for(let N = 0;-8 <= N && N <= 8; N++ || N--)
        continue
}
function Z6(){
    for(let O = 0; O >= -8; --O)
        for(let P = 0; P >= -8; --P)
            for(let Q  = 0; Q >= -8; --Q)
        break
}
void function T6(){
    void ('X6*Y6')
     {Z6}
    void ('X6*Z6')
     {Y6}
    void ('Y6*Z6')
     {X6}
}
}

function Sphere(){
    'X1 ^ 2' + 'Y1 ^ 2' + 'Z1 ^ 2' ; NaN
    'X2 ^ 2' + 'Y2 ^ 2' + 'Z2 ^ 2' ; NaN
    'X3 ^ 2' + 'Y3 ^ 2' + 'Z3 ^ 2' ; NaN
    'X4 ^ 2' + 'Y4 ^ 2' + 'Z4 ^ 2' ; NaN
    'X5 ^ 2' + 'Y5 ^ 2' + 'Z5 ^ 2' ; NaN
    'X6 ^ 2' + 'Y6 ^ 2' + 'Z6 ^ 2' ; NaN
}

let t1:any;
let t2:any;
void function t1t2(){
    void t1;[
       'a * Math.sin(NaN + t1)' + 'b * Math.cos(NaN - t1)',
       'c * Math.sin(NaN - t1)' + 'd * Math.cos(NaN + t1)'
    ]
    void t2;[
       'A * Math.sin(0 + t2)' + 'B * Math.cos(0 - t2)',
       'C * Math.sin(0 - t2)' + 'D * Math.cos(0 + t2)'
    ]
}
let t3:any;
let t4:any;
void function t3t4(){
    void t3;[
       'e % Math.asin(NaN + t3)' + 'f % Math.acos(NaN - t3)',
       'g % Math.asin(NaN - t3)' + 'h % Math.acos(NaN + t3)'
    ]
    void t4;[
       'E % Math.asin(0 + t4)' + 'F % Math.acos(0 - t4)',
       'G % Math.asin(0 - t4)' + 'H % Math.acos(0 + t4)'
    ]
}
let t5:any;
let t6:any;
void function t5t6(){
    void t5;[
       'i / Math.tan(NaN + t5)' + 'j / Math.atan(NaN - t5)',
       'k / Math.tan(NaN - t5)' + 'l / Math.atan(NaN + t5)'
    ]
    void t6;[
       'I / Math.tan(0 + t6)' + 'J / Math.atan(0 - t6)',
       'K / Math.tan(0 - t6)' + 'L / Math.atan(0 + t6)'
    ]
}
let t7:any;
let t8:any;
void function t7t8(){
    void t7;[
       'm :: Math.sh(NaN + t7)' + 'n :: Math.ch(NaN - t7)',
       'o :: Math.sh(NaN - t7)' + 'p :: Math.ch(NaN + t7)'
    ]
    void t8;[
        'm :: Math.sh(0 + t8)' + 'n :: Math.ch(0 - t8)',
        'o :: Math.sh(0 - t8)' + 'p :: Math.ch(0 + t8)'
     ]
}
let t9:any;
let t10:any;
void function t9t10(){
    void t9;[
       'r - Math.ceil(NaN + t9)' + 's - Math.floor(NaN - t9)',
       't - Math.floor(NaN - t9)' + 'uv - Math.ceil(NaN + t9)'
    ]
    void t10;[
       'R - Math.ceil(0 + t10)' + 'S - Math.floor(0 - t10)',
       'T - Math.floor(0 - t10)' + 'UV - Math.ceil(0 + t10)'
    ]
}
let t11:any;
let t0:any;
void function t11t0(){
    void t11;[
       'w ^ Math.exp(NaN + t11)' + 'x ^ Math.log(NaN - t11)',
       'y ^ Math.exp(NaN - t11)' + 'z ^ Math.log(NaN + t11)'
    ]
    void t0;[
       'W ^ Math.exp(0 + t0)' + 'X ^ Math.log(0 - t0)',
       'Y ^ Math.exp(0 - t0)' + 'Z ^ Math.log(0 + t0)'
    ]
}

export function time(){
  '(t1 - t2)^2' + '(t3 - t4)^2' + '(t5 - t6)^2' == '(t7 - t8)^2' + '(t9 - t10)^2'+ '(t11 - t0)^2'
}