double percentualDeBonus, percentualDeRetorno; 
double PontosATransferir, pontosAReduzir, pontosAcrescentar; 

Console.Clear();
Console.WriteLine (":::::::Milhas Bumerange:::::::"); 

Console.Write("Percentual de bonus....: ");
percentualDeBonus = Convert.ToDouble(Console.ReadLine ()); 

Console.Write("Percentual de retorno.....: "); 
percentualDeRetorno = Convert.ToDouble(Console.ReadLine ()); 

Console.Write("Pontos a transferir.....: "); 
PontosATransferir = Convert.ToDouble(Console.ReadLine ()); 

pontosAReduzir = PontosATransferir - (PontosATransferir * percentualDeRetorno) /100; 
pontosAcrescentar = PontosATransferir + (PontosATransferir * percentualDeBonus) /100;

Console.WriteLine();
Console.WriteLine($"pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"pontos a acrescentar no destino...:  {pontosAcrescentar}");

