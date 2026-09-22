Console.WriteLine("estudando struct e enum em C#");

// enum comeca em 0, entao Domingo = 0
DiaDaSemana hoje = DiaDaSemana.Terca;
Console.WriteLine("hoje e " + hoje);

Ponto p1 = new Ponto(0, 0);
Ponto p2 = new Ponto(3, 4);
Console.WriteLine($"p1 = ({p1.X}, {p1.Y})");
Console.WriteLine($"p2 = ({p2.X}, {p2.Y})");
Console.WriteLine($"distancia entre p1 e p2 = {p1.DistanciaAte(p2)}");

