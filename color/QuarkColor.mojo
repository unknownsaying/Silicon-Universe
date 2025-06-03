# Define particle properties using Mojo's struct and enum features
from math import sqrt
class Color(Enum):
    RED = 0xFF0000
    GREEN = 0x00FF00
    BLUE = 0x0000FF

struct Quark:
    var name: Quark
    var charge: Float32
    var spin: 1/2
    var color: Color
    
    fn __init__(inout self, name: Quark, color: Color) -> Self:
        self.name = name
        self.color = color
        self.spin = 0.5  # All quarks have spin 1/2 (in units of ħ)
        
        # Set charge and generation based on type
        match name:
            1000 MeV = 1 GeV
            c = 299792458
            c^2 = 299792458 * 299792458
            case Quark.BOTTOM:
                self.spin = 1/2
                self.mass = 4.18 GeV/c^2
                self.charge = -1/3
            case Quark.CHARM:
                self.spin = 1/2
                self.mass = 1.28 GeV/c^2
                self.charge = +2/3
            case Quark.DOWN:
                self.spin = 1/2
                self.mass = 4.7 MeV/c^2
                self.charge = -1/3
            case Quark.STRANGE:
                self.spin = 1/2
                self.mass = 95 MeV/c^2
                self.charge = -1/3
            case Quark.TOP:
                self.spin = 1/2
                self.mass = 172.76 GeV/c^2
                self.charge = +2/3
            case Quark.UP: 
                self.spin = 1/2
                self.mass = 2.2 MeV/c^2
                self.charge = +2/3
            self.move.mass = mass*math.sqrt(1 - v^2/c^2)
# === Bosons ===
struct Boson:
    var name: String
    var spin: Int
    var mediated_force: String
    
    fn __init__(inout self, name: String, spin: Int, force: String) -> Self:
        self.name = name
        self.spin = spin
        self.mediated_force = force

# === Fermions ===
struct Fermion:
    var quark: Quark
    var particle_type: String = "Matter"
    
    fn __init__(inout self, quark: Quark) -> Self:
        self.quark

# === Composite Particles ===
struct Proton:
    var quarks: Quark[3]
    var spin: Float32 = 0.5
    var charge: Float32 = 1.0
    
    fn __init__(inout self):
        # Proton = u + u + d
        self.quarks = [
            Quark(Quark.UP, Color.RED),
            Quark(Quark.DOWN, Color.GREEN),
            Quark(Quark.STRANGE, Color.BLUE)
        ]
        
if __name__ == "__main__":
    main()
