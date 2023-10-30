//دنباله فیبوناچی
//یاسین عربی
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
        

        
int first = 0;
int second = 1;
int next;
  
Console.Write( second + " " );
for (int i = 2; i <= n; i++)
{
    next = first + second;
    Console.Write(next + " ");
    first = second;
    second = next;
}
        
    





