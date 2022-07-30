// aritmetik operatorler

int x = 3;
int y = 3; 

//int z = x + y;

y= y + 2;
Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
x += 4;
Console.WriteLine(x);
x *= 7;
Console.WriteLine(x);

//mantıksal operatörler

bool isSuccess =true;
bool isCompleted = false;

if ( isSuccess && isCompleted )

Console.WriteLine("perfect!");
if (isSuccess || isCompleted)

Console.WriteLine("great!");

if (isSuccess && !isCompleted)
Console.WriteLine("fine!");

// ilişkisel operatörler

int a = 3;
int b = 4; 

bool sonuc  = a<b;
Console.WriteLine(sonuc); //true
sonuc = a>b;
Console.WriteLine(sonuc); //false
sonuc = a != b;
Console.WriteLine(sonuc); //true
sonuc = a<= b;
Console.WriteLine(sonuc); //true
sonuc = a>= b;
Console.WriteLine(sonuc); //false

//mod alma 

int sonuc2 = 20%3;
Console.WriteLine(sonuc2);


 

Console.ReadLine();
