
    static void Problema_6()
    {
    Console.WriteLine("Digite o valor do investimento:");
    double valorInves = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o valor da taxa de juros:");
    double taxaMensal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o numero de meses da aplicacao");
    int meses = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o numero de dias da aplicacao");
    int dias = Convert.ToInt32(Console.ReadLine());

    //  F = p * ( 1 + i ) ^n
    double periodo = meses + (dias / 30.0);
    double calc = valorInves * Math.Pow(1 + taxaMensal / 100, periodo);
    Console.WriteLine($"O valor do renidmento final é: {calc:F2} ");
    }
    Problema_6();
    





