imports color/Green.vb
imports color/Blue.vb
imports color/Red.vb
imports color/anti.vb
Module XYZT
Class SpherePoint
    let X = r * Math.sin(theta) * Math.cos(fai)
    let Y = r * Math.sin(theta) * Math.sin(fai)
    let Z = r * Math.cos(fai)
    let T = r * Math.sin(theta)
    return X,Y,Z,T
End Class

Class SphereRadius
    const SphereRadiusx = Math.sin(y) + Math.cos(z) 
    const SphereRadiusy = Math.sin(x) + Math.cos(z) 
    const SphereRadiusz = Math.sin(y) + Math.cos(x)
    return SphereRadiusx, SphereRadiusy, SphereRadiusz
End Class
End Module
