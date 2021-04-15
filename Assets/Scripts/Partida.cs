
public interface Partida {

	void reproducirSonido();
	
	void seleccionAdversario();

	void actualizarTexto(bool bando,string texto);
	
	void actualizarVida(bool bando,float dmg);
	
	void actualizarMana(bool bando,float dmg);
	
}