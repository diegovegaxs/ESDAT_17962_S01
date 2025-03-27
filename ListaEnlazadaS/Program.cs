using ListaEnlazadaS;

Locomotora l = new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
l.AgregaPrimero(4);
Console.WriteLine(l.VerVagones());
