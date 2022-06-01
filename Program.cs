// See https://aka.ms/new-console-template for more information
string stranger = "Samuel";
int age = 29;

Console.WriteLine($"Hello, {stranger} {age}");

Console.WriteLine(stranger.IndexOf('l'));

int a = 10, b = 20, c = 40;

double sum = a + b + c;
int max = int.MaxValue;
int maxIsh = max + 3;

Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"what is {sum/3}");
Console.WriteLine($"what is the max of double? {double.MaxValue}");
Console.WriteLine(maxIsh);
Console.WriteLine("----------------------------Array------------------------------");

//var arr2 = new int[] {1,2,3,4};

var firstArr = new int[5] {-5,45,32,1,4};

firstArr[0] = 100;

for(int i = 0; i < firstArr.Length; i++){
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
}

foreach(var el in firstArr){
    Console.WriteLine($"The value is {el}" );
}