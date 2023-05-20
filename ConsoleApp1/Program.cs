using Ejercicios;

//Console.WriteLine("****************************");
//Console.WriteLine(" MULTIPLICACION DE MATRICES ");
//Console.WriteLine("****************************");

//Console.Write("Ingrese el valor de m: ");
//int m = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el valor de n: ");
//int n = int.Parse(Console.ReadLine());

//Console.Write("Ingrese el valor de p: ");
//int p = int.Parse(Console.ReadLine());

//int[,] A = Matrix.GetFillMyMatriz(m, n, "A");
//int[,] B = Matrix.GetFillMyMatriz(n, p, "B");
//int[,] C = Matrix.GetMultiplyMatriz(A, B);

//Console.Write("*** A *** \n");
//Console.Write(Matrix.ToString(A));
//Console.Write("*** B *** \n");
//Console.Write(Matrix.ToString(B));
//Console.Write("*** C *** \n");
//Console.Write(Matrix.ToString(C));

//Console.WriteLine("***********************");
//Console.WriteLine("     RELOJ DE ARENA    ");
//Console.WriteLine("***********************");

//Console.WriteLine("Enter the order of the matrix (N):");
//int N = int.Parse(Console.ReadLine());

//int[,] matrix = Clock.FillMatrix(N);

//Console.WriteLine("Complete Matrix:");
//Clock.PrintMatrix(matrix);

//Console.WriteLine("hourglass:");
//Clock.PrintHourglass(matrix);


//Console.WriteLine("****************************");
//Console.WriteLine(" DESCOMPOSICION EN FACTORES ");
//Console.WriteLine("****************************");

//Console.Write("Ingrese el número a descomponer: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write(num1 + " = ");
//PrimeFactors.GetPrimeFactors(num1);

//Console.Write("Ingrese el número a descomponer: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write(num2 + " = ");
//PrimeFactors.GetPrimeFactors(num2);

Console.WriteLine("**********************");
Console.WriteLine(" COSECHANDO A CABALLO ");
Console.WriteLine("**********************");

ChessBoard chessBoard = new ChessBoard();
Console.Write("Ingrese ubicación de los frutos: ");
chessBoard.SetFruits(Console.ReadLine());
Console.Write("Ingrese posición inicial del caballo: ");
chessBoard.SetHorsePosition(Console.ReadLine());
Console.Write("Ingrese los movimientos del caballo: ");
Console.WriteLine("Los frutos recogidos son: " + chessBoard.Harvest(Console.ReadLine()));

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
