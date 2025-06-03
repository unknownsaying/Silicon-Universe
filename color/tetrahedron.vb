Imports sphere.vb
function Coordinate
  return [
    r * Math.cos(phi) * Math.sin(theta),
    r * Math.sin(phi) * Math.sin(theta),
    r * Math.cos(theta)
  ]
End Function
  const Length = 1; 
  const r = Length;
  const vertices = [
    Coordinate(0,0,1),//A
    Coordinate(Math.acos(-1/3), 0,0), // B
    Coordinate(0, -Math.acos(-1/3),0), // C
    Coordinate(0,0,Math.acos(-1/3)), // D
  ]
  for (let i = 0; i < vertices.length; ++i) {
    vertices[i] = [vertices[i][0] * r, vertices[i][1] * r, vertices[i][2] * r];
  }
  vertices.forEach((vertex, index) => {
    console.WriteLine(`Vertex {index}: ({vertex[0]}, {vertex[1]}, {vertex[2]})`);
  })

  
