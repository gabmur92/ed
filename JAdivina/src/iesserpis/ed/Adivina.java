package iesserpis.ed;

import java.util.Scanner;

public class Adivina {

	public static void main(String[] args) {
		Scanner tcl=new Scanner(System.in);
// un numero aleatorio entre el 1 y el 1000
		int x=(int)(Math.random()*1000);
		int intentos=1;
		int num=0;
		
		System.out.println(x);
		System.out.println("Adivina un numero entre 1 y 1000 ");
//para entrar en el programa  tienes que introducir un numero diferente de la respuesta, si no saldra
		while(num != x&&intentos<25) {
			num= tcl.nextInt();
// si aciertas entrara aqui si no saltara
			if(num==x) {
//dependiendo de los intentos  te dara una respuesta u otra
				if (intentos<=5) {
					System.out.println("Felicidades eres un maquina, as acertado con solo "+intentos+" intentos");	
					}
				else if(intentos>5 && intentos<=10) {
					System.out.println("No esta mal con "+intentos+" intentos");	
					}
				else if(intentos>10 && intentos<=15) {
					System.out.println("Bueno "+intentos+" intentos podria ser mejorable...");	
					}
				else {
					System.out.println(intentos+"..... Dedicate a otra cosa, te ira mejor");	
					}							
			}
//si no has acertado comprobara si es mayor o menor
			else if(num>x) {
				System.out.println("El numero "+num+" es mayor");	
				}
			else { 
				System.out.println("El numero "+num+" es menor");	
				}		
			intentos++;		
			
		}
		if(intentos<25) {
		System.out.println("Has ganado, Fin de programa");
		}
		else
			System.out.println("Demasiados intentos Has perdido, Fin de programa");
	}
}


