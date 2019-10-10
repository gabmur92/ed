import java.util.Scanner;
public class JAdivina {

	public static void main(String[] args) {
		Scanner tcl=new Scanner(System.in);
		int num=0;
		int x=(int)(Math.random()*1000+1);
		int intentos=0;
		
		System.out.println("adivina el numero  ( 1 para iniciar 0 para terminar)");
		num= tcl.nextInt();
		System.out.println("adivina el numero entre 1 y 1000 ");
		
		while(num != x) {
			num= tcl.nextInt();
			
			if(num==x) {
				System.out.println("Felicidades as acertado con "+intentos+" intentos");				
		}
				else if(num>x) {
						System.out.println("el numero "+num+" es mayor");
									
		}
				else{ 
						System.out.println("el numero "+num+" es menor");
								
		}
			intentos++;
		}
}
}