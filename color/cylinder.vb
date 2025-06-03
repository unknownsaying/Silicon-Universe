imports sphere.vb
imports color.css
imports Red.vb
imports Green.vb
imports Blue.vb
imports anti.vb
Function CylinderXY
  const element1=
           [[1,0,0,0],
            [0,1,0,0],
            [0,0,1,0],
            [0,0,0,1]]

 const element2=
           [[0,1,0,0],
            [0,0,1,0],
            [0,0,0,1],
            [1,0,0,0]]

 const element3=
           [[0,0,0,1],
            [1,0,0,0],
            [0,1,0,0],
            [0,0,1,0]]

  const  element4 =
           [[0,0,1,0],
            [0,0,0,1],
            [1,0,0,0],
            [0,1,0,0]]
End function
function CylinderYZ
    const element5 =
           [[1,0,1,0],
            [0,1,0,0],
            [0,0,1,0],
            [0,0,0,1]]

    const element6 =
           [[1,0,0,0],
            [0,1,0,1],
            [0,0,1,0],
            [0,0,0,1]]

    const element7 =
           [[1,0,0,0],
            [0,1,0,0],
            [0,0,1,0],
            [0,1,0,1]]

    const element8 =
           [[1,0,0,0],
            [0,1,0,0],
            [1,0,1,0],
            [0,0,0,1]]
End function
function CylinderXZ
    const element9 =
           [[0,1,0,1],
            [1,0,1,0],
            [0,0,0,1],
            [0,0,0,0]]

    const element10 =
           [[0,1,0,1],
            [0,0,1,0],
            [0,1,0,1],
            [0,0,0,0]]

    const element11 =
           [[0,1,0,1],
            [0,0,1,0],
            [0,0,0,1],
            [0,0,1,0]]

    const element12 =
           [[0,1,0,1],
            [0,0,1,0],
            [0,0,0,1],
            [1,0,0,0]]
End function
function CylinderXYZ
    const element13 =
        [[1,0,1,0],
            [0,0,0,1],
            [1,0,0,0],
            [0,1,0,0]]

    const element14 =
        [[0,0,1,0],
            [0,1,0,1],
            [1,0,0,0],
            [0,1,0,0]]

    const element15 =
           [[0,0,1,0],
            [0,0,0,1],
            [1,0,1,0],
            [0,1,0,0]]

    const element16 =
           [[0,0,1,0],
            [0,0,0,1],
            [1,0,0,0],
            [0,1,0,1]]

    const element17 =
           [[0,1,0,0],
            [1,0,0,0],
            [0,1,0,0],
            [1,0,1,0]]

    const element18 =
           [[0,0,0,0],
            [1,0,1,0],
            [0,1,0,0],
            [1,0,1,0]]

    const element19 =
           [[0,0,0,0],
            [1,0,0,0],
            [0,1,0,1],
            [0,0,1,0]]

    const element20 =
           [[0,0,0,1],
            [1,0,0,0],
            [0,1,0,0],
            [0,0,1,0]]
End function
Sub Cylinder
    const CylinderXY = Cylinder.X + Cylinder.Y
    const CylinderYZ = Cylinder.Y + Cylinder.Z
    const CylinderZX = Cylinder.Z + Cylinder.X
    const CylinderXYZ = Cylinder.XY + Cylinder.YZ + Cylinder.XZ
    return [CylinderXY,CylinderYZ,CylinderZX,CylinderXYZ,X,Y,Z]
End Sub
