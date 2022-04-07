Console.WriteLine("do zaszyfrowania");
string a = Console.ReadLine();
a = a.ToUpper();
char[] achar = a.ToCharArray();
int m;
Console.WriteLine("klucz");
m = Int32.Parse(Console.ReadLine());
for (int e = 0; e < achar.Length; e++)
{
    achar[e] = (char)((achar[e] + m));
    if (achar[e] > 90)
    {
        achar[e] = (char)((char)achar[e] - 26);
    }

}
string b = new string(achar);
Console.WriteLine("szyfrowana");
Console.WriteLine(b);
