package Herança;

public class Herança {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Funcionario funcionario= new Funcionario();
		TesteGerente gerente= new TesteGerente();
		
		
		gerente.set_nome("SilvoSantos");
		System.out.println(gerente.get_Nome());	
		gerente.set_senha("kakakaka");
		System.out.println(gerente.get_senha());	
		gerente.set_Salario(10000);
		System.out.println("R$"+gerente.get_SalarioTotal());

		}

}
class Funcionario {
	protected String nome;
	private String cpf;
	private double salario;
	
	public String get_Nome() {
		return nome;
	}
	public void set_Nome(String nome) {
		this.nome=nome;
	}
	public String get_Cpf() {
		return cpf;
	}
	public void set_Cpf(String cpf) {
		this.cpf=cpf;
	}
	public void set_Salario(double salario) {
		this.salario=salario;
	}
	public double get_salario() {
		return salario;
	}
	public double bonificacao() {
		return this.get_salario()*0.10;
	}
	public double get_SalarioTotal() {
		return this.bonificacao()+this.get_salario();
	}
}

class Gerente extends Funcionario{
	protected String senha;
	private int num_func_Gerenciados;
	
	public void validar_senha() {
		
	}
	public String get_senha() {
		return this.senha;
	}
	public double bonificacao() {
		return this.get_salario()*0.15;
	}
	public double get_SalarioTotal() {
		return this.bonificacao()+this.get_salario();
	}

}

class TesteGerente extends Gerente{
	public void set_senha(String senha) {
		this.senha=senha;
	}

	public void set_nome(String nome) {
		this.nome=nome;
	}

}