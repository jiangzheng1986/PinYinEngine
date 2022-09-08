# PinYinEngine
A minimal Chinese to PinYin converter. There is only one single file of this converter (which is PinYinEngine.cs) and mainly one single interface function (which is PinYinEngine.GetPinYin()), make this library easy to use and integrate;

```
string Chinese = "十年磨一剑。";
string PinYin = PinYinEngine.GetPinYin(Chinese, "_");
```