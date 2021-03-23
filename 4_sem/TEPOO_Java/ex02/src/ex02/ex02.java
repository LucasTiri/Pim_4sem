package ex02;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

public class ex02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//ex01
		/*
        BufferedReader obj = new BufferedReader(new InputStreamReader(System.in));
        String str = null;
        int num;
        System.out.println("Quantos quilos :");
        try {
            str=obj.readLine();
        } catch (IOException e) {
            e.printStackTrace();
        }
        num = Integer.parseInt(str);
        int resultado = (num*1000) / 50;
        System.out.println(resultado);
		*/
		//ex02
		/*
		Scanner entrada = new Scanner (System.in);
		int cat1=0;
		int cat2=0;
		System.out.println("Digite o num do cateto1: ");
		cat1=entrada.nextInt();
		System.out.println("Digite o num do cateto2: ");
		cat2=entrada.nextInt();
		double hipo=(cat1^2)+(cat2^2);
		hipo=Math.sqrt(hipo);
		System.out.print(hipo);
		*/
		//ex03
		/*Scanner entrada = new Scanner (System.in);
		int macas=0;
		int melancia=0;
		int laranja=0;
		System.out.print("Digite quantas Maçãs: ");
		macas=entrada.nextInt();
		System.out.print("Digite quantas Melancias: ");
		melancia=entrada.nextInt();
		System.out.print("Digite quantas Laranjas: ");
		laranja=entrada.nextInt();
		
		double total=(macas*1.30)+(melancia*4)+(laranja*0.30);
		System.out.print(total);
		*/
		//ex04
		/*
		Scanner entrada = new Scanner (System.in);
		double n1=0;
		double n2=0;
		double media=0;
		System.out.print("Digite a nota 1: ");
		n1=entrada.nextInt();
		System.out.print("Digite a nota 2: ");
		n2=entrada.nextInt();
		media = (n1+n2)/2;
		if(media>=8.0) {
			System.out.print("Parabéns pela nota");
		}else {
			System.out.print("Nota Regular");
		}
		*/
		//ex05
		/*
		Scanner entrada= new Scanner(System.in);
		int n1=0;
		int n2=0;
		int n3=0;
		System.out.print("Digite n1: ");
		n1=entrada.nextInt();
		System.out.print("Digite n2: ");
		n2=entrada.nextInt();
		System.out.print("Digite n3: ");
		n3=entrada.nextInt();
		
		if (n1>n2 && n1>n3) {
			System.out.print("N1 maior");
		}else if(n2>n1 && n2>n3) {
			System.out.print("N2 maior");
		}else if(n3>n1 && n3>n2){
			System.out.print("N3 maior");
		}else {
			System.out.print("Numero errado ou igual");
		}
		*/
		//ex06
		/*
		Scanner entrada= new Scanner(System.in);
		int horas=0;
		int val_hora=0;
		double val_extra=0;
		int dif_hora=0;
		double result=0;
		System.out.print("Digite o numero de horas: ");
		horas=entrada.nextInt();
		System.out.print("Digite o valor ganhado por hora: ");
		val_hora=entrada.nextInt();
		
		if(horas<=40) {
			result=horas*val_hora;
			System.out.print(result);
		}else {
			dif_hora=horas-40;
			val_extra=(val_hora+(val_hora/2))*dif_hora;
			result=val_extra+(val_hora*(horas-dif_hora));
			System.out.print(result);
		}
		*/
		//ex07
		/*
		Scanner entrada= new Scanner(System.in);
		double sal_fix=0;
		double comissao=0;
		double vendas=0;
		double sal_total=0;
		
		System.out.print("Digite o seu salario fixo: ");
		sal_fix=entrada.nextInt();
		System.out.print("Digite a quantidade de vendas efetuadas: ");
		vendas=entrada.nextInt();
		
		comissao=vendas*((sal_fix*3)/100);
		sal_total=comissao+sal_fix;
		if(comissao>=20000) {
			System.out.println("Atingiu a Meta!!!");
			sal_total+=600;
			System.out.print("R$"+sal_total);
		}else {
			System.out.print("R$"+sal_total);
		}
		*/
		//ex08
		/*
		Scanner entrada= new Scanner(System.in);
		String num_conta="";
		double saldo=0;
		double credito=0;
		double debito=0;
		double saldo_atual=0;
		System.out.print("Digite o num da sua conta: ");
		num_conta=entrada.next();
		System.out.print("Digite seu saldo: ");
		saldo=entrada.nextDouble();
		System.out.print("Digite seu debito: ");
		debito=entrada.nextDouble();
		System.out.print("Digite seu credito: ");
		credito=entrada.nextDouble();
		
		saldo_atual=saldo-debito+credito;
		if(saldo_atual>0) {
			System.out.print("Saldo Positivo");
		}else {
			System.out.print("Saldo Negativo");
		}
		*/
		//ex09
		/*
		Scanner entrada= new Scanner(System.in);
		double estoque_atual;
		double estoque_minimo=10;
		double estoque_max=100;
		double estoque_med=estoque_minimo*estoque_max/2;
		System.out.print("Digite o estoque atual: ");
		estoque_atual=entrada.nextDouble();
		if(estoque_atual>=estoque_med) {
			System.out.print("Não efetuar compra");
		}else {
			System.out.print("Efetuar compra");
		}
		*/
		//ex10
		Scanner entrada= new Scanner(System.in);
		double litros_vend=0;
		int tipo_combustivel=0;
		double total=0;
		System.out.print("Digite o tipo de combustivel 1-Alcool 2-Gasolina: ");
		tipo_combustivel=entrada.nextInt();
		System.out.print("Digite a quantidade de litros que serão vendidos: ");
		litros_vend=entrada.nextDouble();
		if(tipo_combustivel == 1) {
			total=litros_vend*3.90;
			System.out.println("total: "+total);
		}else if(tipo_combustivel==2) {
			total=litros_vend*4.30;
			System.out.println("total: "+total);
		}
	}	
}
