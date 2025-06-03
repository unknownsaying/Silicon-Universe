import math
import time
def xyznnn(x, y, z, n):
        return [
        (x-n,y+n,z-n, x-n,y+n,z+n, x+n,y+n,z+n, x+n,y+n,z-n)， # a
        (x-n,y-n,z-n, x+n,y-n,z-n, x+n,y-n,z+n, x-n,y-n,z+n)， # b
        (x-n,y-n,z-n, x-n,y-n,z+n, x-n,y+n,z+n, x-n,y+n,z-n)， # c
        (x+n,y-n,z+n, x+n,y-n,z-n, x+n,y+n,z-n, x+n,y+n,z+n)， # d
        (x-n,y-n,z+n, x+n,y-n,z+n, x+n,y+n,z+n, x-n,y+n,z+n)， # e
        (x+n,y-n,z-n, x-n,y-n,z-n, x-n,y+n,z-n, x+n,y+n,z-n)， # f
    ]
class X():    
    def smallX(n):
        for SmallX in range([n][0][n],
                            [0][n][0],
                            [n][0][n]):
                        [1,2,3,4,5,6,7,8,9]  
                                
    def MiddleX(n):
        for MiddleX in range([n][0][0][n],
                             [0][n][n][0],
                             [0][n][n][0],
                             [n][0][0][n]):
                        [1,2,3,4,5,6,7,8,9]

    def BigX(n):
        for BigX in range([n][0][0][0][n],
                          [0][n][0][n][0],
                          [0][0][n][0][0],
                          [0][n][0][n][0],
                          [n][0][0][0][n]):
                        [1,2,3,4,5,6,7,8,9]
                              
class Y():    

    def smallY(n):
        for SmallY in range([n][0][n],
                            [0][n][0],
                            [0][n][0]):
                        [1,2,3,4,5,6,7,8,9]
                                
    def MiddleY(n):
        for MiddleY in range([n][0][0][n],
                             [0][n][n][0],
                             [0][n][n][0],
                             [0][n][n][0]):
                        [1,2,3,4,5,6,7,8,9]

    def BigY(n):
        for BigY in range([n][0][0][0][n],
                          [0][n][0][n][0],
                          [0][0][n][0][0],
                          [0][0][n][0][0],
                          [0][0][n][0][0]):
                        [1,2,3,4,5,6,7,8,9]

class Z():    

        
    def smallZ(n):
        for SmallZ in range([n][n][n],
                            [0][n][0],
                            [n][n][n]):
                        [1,2,3,4,5,6,7,8,9]
                                
    def MiddleZ(n):
        for MiddleZ in range([n][n][n][n],
                             [0][0][n][0],
                             [0][n][0][0],
                             [n][n][n][n]):
                        [1,2,3,4,5,6,7,8,9]

    def BigZ(n):
        for BigZ in range([n][n][n][n][n],
                          [0][0][0][n][0],
                          [0][0][n][0][0],
                          [0][n][0][0][0],
                          [n][n][n][n][n]):
                        [1,2,3,4,5,6,7,8,9]
                              
class N(): 
        
    def smallN(n):
        for SmallZ in range([n][0][n],
                            [n][n][n],
                            [n][0][n]):
                        [1,2,3,4,5,6,7,8,9]
                                
    def MiddleN(n):
        for MiddleZ in range([n][0][0][n],
                             [n][n][0][n],
                             [n][0][n][n],
                             [n][0][0][n]):
                        [1,2,3,4,5,6,7,8,9]
               
    def BigN(n):
        for BigZ in range([n][0][0][0][n],
                          [n][n][0][0][n],
                          [n][0][n][0][n],
                          [n][0][0][n][n],
                          [n][0][0][0][n]):
                        [1,2,3,4,5,6,7,8,9]
            
    def three(n):
        for inner in range([n-4],[n-3],[n-2],
                           [n-1],[n] ,[n+1],
                           [n+2],[n+3],[n+4]):
                        [1,2,3,4,5,6,7,8,9]
        
        for outer in range([n+4],[n+3],[n+2],
                           [n+1],[n] ,[n-1],
                           [n-2],[n-3],[n-4]):
                        [9,8,7,6,5,4,3,2,1]
                               
    def four(n):
        for inner in range([n+1],[n+1],[n+1],[n+1],
                           [n+1],[n],[n],[n+1],
                           [n+1],[n],[n],[n+1],
                           [n+1],[n+1],[n+1],[n+1]):
                        [0,1,2,3,4,5,6,7,8,9]
        
        for outer in range([n],[n],[n],[n],
                           [n],[n-1],[n-1],[n],
                           [n],[n-1],[n-1],[n],
                           [n],[n],[n],[n]):
                        [1,2,3,4,5,6,7,8,9,0]
            
    def five(n):
        for innerL in range([n],[n+1],[n+2],[n+3],[n+4],
                           [n+15],[n+16],[n+17],[n+18],[n+5],
                           [n+14],[n+23],[n+24],[n+19],[n+6],
                           [n+13],[n+22],[n+21],[n+20],[n+7],
                           [n+12],[n+11],[n+10],[n+9],[n+8]):
                         [1,-3,-8,-14]

        for innerR in range([n+1],[n+16],[n+15],[n+14],[n+13],
                           [n+2],[n+17],[n+24],[n+23],[n+12],
                           [n+3],[n+18],[n+25],[n+22],[n+11],
                           [n+4],[n+19],[n+20],[n+21],[n+10],
                           [n+5],[n+6],[n+7],[n+8],[n+9]):
                        [0,-4,-9,-15]
       
        for outerL in range([n+12],[n+11],[n+10],[n+9],[n+24],
                           [n+13],[n+2],[n+1],[n+8],[n+23],
                           [n+14],[n+3],[n],[n+7],[n+22],
                           [n+15],[n+4],[n+5],[n+6],[n+21],
                           [n+16],[n+17],[n+18],[n+19],[n+20]):
                        [1,-3,-8,-14]
        
        for outerR in range([n+17],[n+18],[n+19],[n+20],[n+21],
                           [n+16],[n+5],[n+6],[n+7],[n+22],
                           [n+15],[n+4],[n+1],[n+8],[n+23],
                           [n+14],[n+3],[n+2],[n+9],[n+24],
                           [n+13],[n+12],[n+11],[n+10],[n+25]):
                        [0,-4,-9,-15]
