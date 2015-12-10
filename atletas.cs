//estrutura atletas////////////////////////////////////////////
class Atleta
{
	private int forcaRemate; //características atletas
	private char pePref;
	private int imprevisibilidade;
	private string nomeAtleta;
}

public Atleta(int fRemate, char pePreferido, int imprev, string nomeAtl)
{
	this.forcaRemate = fRemate;
	this.pePref = pePreferido;
	this.imprevisibilidade = imprev;
	this.nomeAtleta	= nomeAtl;
}	

public int ForcaRemate
{
	get{return forcaRemate;}
	set{forcaRemate = value;}
}

public char PePref
{
	get{return pePref;}
	set{pePref = value;}
}

public int imprevisibilidade
{
	get{return imprevisibilidade;}
	set{imprevisibilidade = value;}
}

public int nomeAtleta
{
	get{return nomeAtleta;}
	set{nomeAtleta = value;}
}

public novoAtleta(int fRemate, char pePreferido, int imprev)
{
	fRemate = forcaRemate;
	pePreferido = pePref;
	imprev = imprevisibilidade;
}
///////////////////////////////////////////////////////////////
/* é necessário criar uma estrutura (i.e. array/lista) para 
armazenar atletas. é necessário arranjar uma solução para os
planos de treino (a partir das características do atleta). 
*/
///////////////////////////////////////////////////////////////

