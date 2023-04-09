// Um projétil é lançado em um ânguo θ° (teta graus) a uma velocidade inicial v0 m/s. Calcule, em metros, o alcance máximo xmax e a altura máxima atingida hmax.

// 1 Da constante π (pi) = 3,14159 radianos
// 2 Da constante g = 9,80665 m/s²
// 3 Converter o ângulo de graus para radianos, como no exemplo: 180° × π/180 = 3rad
// 4 Aplicar a Equação de Torricelli para o alcance
// 5 Aplicar a equação de Torricelli para a altura.

double angulo;
double velInicial;
double anguloRadianos;
double alcMax;
double altMax;

Console.WriteLine("--- Cálculo do Alcance Máximo e Altura Máxima de um Projétil ---\n");

// Enttrada 
Console.Write("Digite o ângulo de lançamento em graus (θ): ");
angulo = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a velocidade inicial em m/s (v0): ");
velInicial = Convert.ToDouble(Console.ReadLine());

// converção
anguloRadianos = angulo * (Math.PI / 180);

//calculo Alc
alcMax = (Math.Pow(velInicial, 2) * Math.Sin(2 * anguloRadianos)) / 9.80665;

//calculo Alt
altMax = (Math.Pow(velInicial, 2) * Math.Pow(Math.Sin(anguloRadianos), 2)) / (2 * 9.80665);

//resultados
Console.WriteLine($"\nAlcance Máximo (xmax): {alcMax:F2} metros");
Console.WriteLine($"Altura máxima (hmax): {altMax:F2} metros");


