Console.WriteLine("estudando struct e enum em C#");

// enum comeca em 0, entao Domingo = 0
DiaDaSemana hoje = DiaDaSemana.Terca;
Console.WriteLine("hoje e " + hoje);

Ponto p1 = new Ponto(0, 0);
Ponto p2 = new Ponto(3, 4);
Console.WriteLine($"p1 = ({p1.X}, {p1.Y})");
Console.WriteLine($"p2 = ({p2.X}, {p2.Y})");
Console.WriteLine($"distancia entre p1 e p2 = {p1.DistanciaAte(p2)}");

Console.WriteLine();
Console.WriteLine("agora comparando struct com classe");

Ponto copiaStruct = p1;
copiaStruct.X = 99;
Console.WriteLine($"p1 (struct) continua ({p1.X}, {p1.Y}), a copia mudou pra ({copiaStruct.X}, {copiaStruct.Y})");

PontoClasse original = new PontoClasse(0, 0);
PontoClasse copiaClasse = original;
copiaClasse.X = 99;
Console.WriteLine($"original (classe) virou ({original.X}, {original.Y}) porque copiaClasse aponta pro mesmo objeto");

