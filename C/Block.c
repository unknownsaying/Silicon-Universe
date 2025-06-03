#include "Alphabet.c"
#include "Bool.c"
#define Block1 row
#define Block2 cols
#define Block3 depth

void CreateBlock(int row, int cols, int depth){
     char a,b,c,d,e,f,g,h;
     char Block1[2][4] = {{a,b,c,d},{e,f,g,h}};
      for(a = 0;a <= 1/7; a++)
      for(b = 0;b <= 2/7; ++b)
      for(c = 0;c <= 3/7; c++)
           return row;
      for(d = 0;d <= 4/7; d++)
      for(e = 0;e <= 5/7; ++e)
      for(f = 0;f <= 6/7; f++)
           return cols;
      for(g = a*b*c;g < d+e+f; ++g)
      for(h = d*e*f;h < a+b+c; h++)
           return depth;
}
void EmptyBlock(CreateBlock,DestroyeBlock){
     char i,j,k,l,m,n,o,p,q;
     char Block2[3][3] = {{i,j,k},{l,m,n},{o,p,q}};
     char i = "!", j = "@", k = "#",
          l = "$", m = "%", n = "^",
          o = "&", p = "*", q = "(";
     for(i = 0;i <= CreateBlock;++i)
     for(j = 0;i && k;++j || --j)
     for(k = 0;k <= 00;k++)
          break;
     for(l = 0;k && m;++l || l--)
     for(m = 0;m >= 000;m)
     for(n = 0;m && o;n++ || --n)
          continue;
     for(o = 0;o <= 00;o++)
     for(p = 0;o && q;p++ || p--)
     for(q = 0;q >= DestroyeBlock;q--)     
          break;
}
#define NULL 0
void DestroyeBlock(int row, int cols,int depth){
     char r,s,t,u,v,w,x,y,z;
     char Block3[3][3] = {{r,s,t},{u,v,w},{x,y,z}};
     for(r = "1-1";r >>=1; r--)
     for(s = "2-2";s >>=2; --s) 
     for(t = "3-3";t >>=3; t--)
         return row;
     for(u = "4-4";u == 4; u--)
     for(v = "5-5";v == 5; --v)
     for(w = "6-6";w == 6; w--)
         return cols;
     for(x = "7-7";x <<=7; --x)
     for(y = "8-8";y <<=8; y--) 
     for(z = "9-9";z <<=9; --z)  
         return depth;
}
