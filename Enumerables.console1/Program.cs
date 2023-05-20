using Enumerables.logic;

Console.WriteLine("****************************");
Console.WriteLine(" MULTIPLICACION DE MATRICES ");
Console.WriteLine("****************************");

Console.Write("Ingrese el valor de m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor de p: ");
int p = int.Parse(Console.ReadLine());

int[,] A = Matrix.GetFillMyMatriz(m, n);
int[,] B = Matrix.GetFillMyMatriz(n, p);
int[,] C = Matrix.GetMultiplyMatriz(A, B);

Console.Write(Matrix.ToString(C));

//Console.WriteLine("***********************");
//Console.WriteLine("     RELOJ DE ARENA    ");
//Console.WriteLine("***********************");

//Console.WriteLine("RELOJ DE ARENA");
//Console.WriteLine("Ingrese la orden de la matriz: ");
//int N = int.Parse(Console.ReadLine());
//int N = 11;

//Dictionary<(int, int), int> clock = Clock.CreateClock(N);

//Console.WriteLine("MATRIZ COMPLETA");
//Clock.ShowMatrix(clock);

//Console.WriteLine("RELOJ DE ARENA");
//Clock.ShowClock(clock);

//Console.WriteLine("****************************");
//Console.WriteLine(" DESCOMPOSICION EN FACTORES ");
//Console.WriteLine("****************************");


//Console.WriteLine("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//List<int> Factors = PrimeFactors.GetPrimeFactors(number);

//Console.Write("Prime Factors of " + number + ":");

//foreach (int f in Factors)
//{
//    Console.WriteLine(Factors + " ");
//}
//Console.WriteLine();

//Console.WriteLine("**********************");
//Console.WriteLine(" COSECHANDO A CABALLO ");
//Console.WriteLine("**********************");

//HarvestField field = new HarvestField();

//Console.WriteLine("Ingrese ubicación de los frutos: (ejemplo: C4+,C7*,E3-,E1=,H4*)");
//string fruitsInput = Console.ReadLine();

//string[] fruits = fruitsInput.Split(',');

//foreach (string fruit in fruits)
//{
//    string position = fruit.Substring(0, 2);
//    string type = fruit.Substring(2);

//    field.AddFruit(position, type);
//}

//Console.WriteLine("Ingrese posición inicial del caballo:");
//string horsePosition = Console.ReadLine();

//Console.WriteLine("Ingrese los movimientos del caballo: (ejemplo: DR,RD,RD,LD,RU,UR,UL)");
//string movesInput = Console.ReadLine();

//string[] moves = movesInput.Split();

//Console.WriteLine("***********************");
//Console.WriteLine(" CABALLOS EN CONFLICTO ");
//Console.WriteLine("***********************");

//HorseBoard board = new HorseBoard();

//Console.WriteLine("Ingrese ubicación de los caballos: (ejemplo: B7,C5,E2,H7,G5,F6)");
//string input = Console.ReadLine();

//string[] horses = input.Split(',');

//foreach (string horse in horses)
//{
//    board.AddHorse(horse);
//}

//board.AnalyzeConflicts();
//board.PrintConflicts();
