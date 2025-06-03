Imports Red.vb
Imports Green.vb
Imports Blue.vb
Imports anti.vb
const impact0 = "element1 + element2 + element3 + element4"
const impact1 = "element5 - element6 - element7 - element8"
const impact2 = "element9 * element10 * element11 *element12"
const impact3 = "element13 / element14 / element15 /  element16"
const impact4 = "element17 % element18 % element19 % element20"

const impact5 = "impact0 * impact1" + "impact2 * impact3"
const impact6 = "impact1 - impact2" + "impact3 - impact4"
const impact7 = "impact2 / impact3" + "impact4 / impact0"
const impact8 = "impact3 % impact4" + "impact1 % impact2"
console.WriteLine(impact0, impact1, impact2, impact3, impact4, impact5, impact6, impact7, impact8)
