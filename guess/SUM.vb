Imports det.vb
Imports one.vb
Imports oppoone.vb
Imports pyramid.vb
Imports square.vb
Imports antisquare.vb
Imports antipyramid.vb
Imports tri.vb
Imports antitri.vb

const DET = det
const tri = tri - antitri
const ONE = one + oppoone
const Square = square * antisquare
const Pyramid = pyramid % antipyramid

const DETtri = DET * tri
const triDET = tri % DET
const ONEsquare = ONE * square
const squareONE = square % ONE
const oppoPyramid = antipyramid / pyramid
const dimPyramid = square - antisquare
Sub SUM
     ["DET/tri"+"tri/DET" == "DETtri"+"triDET"]
     ["DETtri"+"ONEsquare" == "squareONE"+"triDET"]
     ["Pyramid" == "oppoPyramid"+"dimPyramid"]
    return SUM
End Sub
Console.WriteLine(DET,tri,ONE,Square,Pyramid,DETtri,triDET,ONEsquare,squareONE,oppoPyramid,dimPyramid)
