struct Ponto
{
    public double X;
    public double Y;

    public Ponto(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanciaAte(Ponto outro)
    {
        double dx = X - outro.X;
        double dy = Y - outro.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
