[![Build Status](https://ponoorak.visualstudio.com/Nasa/_apis/build/status/TwoLineElements?branchName=master)](https://ponoorak.visualstudio.com/Nasa/_build/latest?definitionId=23&branchName=master)

# Instalation Tle parser

```
Install-Package TwoLineElements
```

# Ussage Tle parser

```
var lines = "STARLINK-24\n" +
                       	"1 44238U 19029D   20182.10581531  .00001387  00000-0  94194-4 0  9999\n" +
                        "2 44238  52.9975 151.8469 0000937  68.7807 291.3284 15.13099176 60950";

TwoLineElementsModel result = TwoLineElements.Parse(lines);
```
Or
```
line0 = "STARLINK-24
string result = TleLine0Parser.Parse(line0)
```
Or
```
line1 = "1 25544U 98067A   08264.51782528 -.00002182  00000-0 -11606-4 0  2927";
Line1Model result = TleLine1Parser.Parse(line1)
```
Or
```
line2 = "2 25544  51.6416 247.4627 0006703 130.5360 325.0288 15.72125391563537";
Line2Model result = TleLine2Parser.Parse(line2)
```


## License
[MIT](https://choosealicense.com/licenses/mit/)
